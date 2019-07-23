﻿using CustomCampaign.Models;
using Photon.Serialization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

#pragma warning disable CS0436

namespace CustomCampaign.Editor
{
    public static class Config
    {
        public static Serializer<AppSettings> AppSettings = new Serializer<AppSettings>(SerializerType.Json, "config.json", true);
        public static Serializer<RecentFileList> RecentFileList = new Serializer<RecentFileList>(SerializerType.Json, "recent.json", true);

        public static void AppendRecentFile(string path)
        {
            FileInfo file = new FileInfo(path);
            if (!file.Exists) return;

            RecentFileList data = RecentFileList.Data;
            if (data.elements.Contains(file.FullName))
                data.elements.RemoveAll((string recent) => recent == file.FullName);
            data.elements.Insert(0, file.FullName);

            data.elements = data.elements.Take(8).ToList();

            RecentFileList.Data = data;
            RecentFileList.Save();
        }

        public static string[] GetRecentFiles()
        {
            RecentFileList.Data.elements.RemoveAll((string file) => !File.Exists(file));
            RecentFileList.Save();

            return RecentFileList.Data.elements.Take(8).ToArray();
        }
    }
}
