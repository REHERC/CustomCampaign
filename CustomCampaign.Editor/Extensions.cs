﻿#pragma warning disable RCS1110
using System;
using System.Text;
using System.IO;
using System.Linq;
using SharpCompress.Archives.Zip;
using System.Security.Cryptography;
using System.Collections.Generic;

public static class Extensions
{
    public static string GetMD5(this FileInfo file)
    {
        if (!file.Exists) return string.Empty;
        using (var stream = File.OpenRead(file.FullName))
        {
            return stream.GetMD5();
        }
    }

    public static string GetMD5(this ZipArchiveEntry entry)
    {
        return entry.OpenEntryStream().GetMD5();
    }

    public static string GetMD5(this Stream stream)
    {
        using (var md5 = MD5.Create())
        {
            var hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }

    public static void WriteContent(this ZipArchiveEntry entry, string value)
    {
        using (StreamWriter writer = new StreamWriter(entry.OpenEntryStream()))
        {
            writer.Write(value);
        }
    }

    public static string ReadContent(this ZipArchiveEntry entry)
    {
        using (StreamReader reader = new StreamReader(entry.OpenEntryStream()))
        {
            return reader.ReadToEnd();
        }
    }

    public static ZipArchiveEntry Get(this ICollection<ZipArchiveEntry> entries, string path)
    {
        foreach (var entry in from item in entries where string.Equals(item.Key, path, StringComparison.InvariantCultureIgnoreCase) select item)
        {
            return entry;
        }
        return null;
    }

    public static void ExtractToFile(this ZipArchiveEntry entry, string path, bool overwrite)
    {
        if (File.Exists(path))
        {
            if (overwrite)
            {
                File.Delete(path);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        using (Stream stream = entry.OpenEntryStream())
        {
            stream.SaveFileStream(path);
        }
    }

    public static ZipArchiveEntry CreateEntryFromFile(this ZipArchive archive, string file, string path)
    {
        using (Stream stream = File.OpenRead(file))
        {
            return archive.AddEntry(path, stream);
        }
    }

    public static ZipArchiveEntry CreateEntry(this ZipArchive archive, string path)
    {
        using (Stream stream = new MemoryStream())
        {
            return archive.AddEntry(path, stream);
        }
    }

    public static void SaveFileStream(this Stream stream, string path)
    {
        using (var file = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            stream.CopyTo(file);
        }
    }

    public static string ToFileSize(this long file_size)
    {
        StringBuilder sb = new StringBuilder(20);
        NativeMethods.StrFormatByteSize(file_size, sb, 20);
        return sb.ToString();
    }

    public static Stream GetStream(this string input)
    {
        return new MemoryStream(Encoding.UTF8.GetBytes(input));
    }

    public static string ToFormattedTime(this double value)
    {
        return TimeSpan.FromSeconds(value).GetDisplayTime();
    }

    public static string GetDisplayTime(this TimeSpan value)
    {
        int hours = value.Hours + (24 * value.Days);

        return $"{hours.GetFormated()} hour{(hours is 1 ? string.Empty : "s")} {value.Minutes.GetFormated()} minute{(value.Minutes is 1 ? string.Empty : "s")} {value.Seconds.GetFormated()}.{value.Milliseconds.GetFormated(3, false)} second{(value.Seconds is 1 && value.Milliseconds is 0 ? string.Empty : "s")}";
    }

    public static string GetFormated(this int value, int length = 2, bool left = true)
    {
        string temp = value.ToString();
        while (temp.Length < length)
        {
            temp = $"{(left ? "0" : string.Empty)}{temp}{(!left ? "0" : string.Empty)}";
        }
        if (temp.Length > length)
        {
            temp = temp.Substring(0, length);
        }
        return temp;
    }
}
