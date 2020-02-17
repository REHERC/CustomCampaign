#pragma warning disable RCS1110
using System;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;

public static class Extensions
{
    public static string GetMD5(this FileInfo file)
    {
        if (!file.Exists) return string.Empty;
        using (var stream = File.OpenRead(file.FullName))
            return stream.GetMD5();
    }

    public static string GetMD5(this ZipArchiveEntry entry)
    {
        return entry.Open().GetMD5();
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
        using (StreamWriter writer = new StreamWriter(entry.Open()))
            writer.Write(value);
    }

    public static string ReadContent(this ZipArchiveEntry entry)
    {
        using (StreamReader reader = new StreamReader(entry.Open()))
            return reader.ReadToEnd();
    }

    public static string ToFileSize(this long file_size)
    {
        StringBuilder sb = new StringBuilder(20);
        NativeMethods.StrFormatByteSize(file_size, sb, 20);
        return sb.ToString();
    }
}
