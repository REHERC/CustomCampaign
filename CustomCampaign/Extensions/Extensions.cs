using System;
using System.IO;

#pragma warning disable RCS1224, RCS1110, RCS1001
public static partial class Extensions
{
    public static string TrimStart(this string input, string cut)
    {
        if (input.StartsWith(cut))
            return input.Substring(cut.Length - 1);
        return input;
    }

    public static string TrimEnd(this string input, string cut)
    {
        if (input.EndsWith(cut))
            return input.Substring(0, input.Length - cut.Length);
        return input;
    }

    public static string CutStart(this string input, char cut)
    {
        string output = input;
        while (output.StartsWith(cut))
            output = output.TrimStart(cut);
        return output;
    }

    public static string CutEnd(this string input, char cut)
    {
        string output = input;
        while (output.EndsWith(cut))
            output = output.TrimEnd(cut);
        return output;
    }

    public static string UpperCase(this string input)
    {
        return input.ToUpper().ToUpperInvariant();
    }

    public static string LowerCase(this string input)
    {
        return input.ToLower().ToLowerInvariant();
    }

    public static bool EndsWith(this string input, char value)
    {
        return input.EndsWith($"{value}");
    }

    public static bool StartsWith(this string input, char value)
    {
        return input.StartsWith($"{value}");
    }

    public static string GetForwardPath(this string path)
    {
        return path.Replace(Path.DirectorySeparatorChar, '/')
                   .Replace(Path.AltDirectorySeparatorChar, '/');
    }

    public static string NormPath(this string input, bool file = true)
    {
        string output = input.GetForwardPath().LowerCase().CutEnd('/');
        if (input.Length == 0) return "";
        bool directory = !file || input.EndsWith(Path.DirectorySeparatorChar) || input.EndsWith(Path.AltDirectorySeparatorChar);
        while (output.Contains("//"))
            output = output.Replace("//", "/");
        return output + (directory ? "/" : "");
    }

    public static void CopyFile(string source, string destination, bool overwrite = true)
    {
        if (File.Exists(source))
            File.Copy(source, destination, overwrite);
    }

    public static string Cipher(this string input, int key, int mod = 32)
    {
        string output = string.Empty;
        foreach (var ch in input)
            output += (char)(ch - (key % mod));
        return output;
    }

    public static string Decipher(this string input, int key, int mod = 32) => input.Cipher(-key, mod);

    public static void WriteStringSecure(this BinaryWriter writer, string value)
    {
        writer.Write(value.Length);
        writer.Write(value.Cipher(value.Length));
    }

    public static string ReadStringSecure(this BinaryReader reader)
    {
        int length = reader.ReadInt32();
        string cipher_val = reader.ReadString();
        string value = cipher_val.Cipher(-length);
        if (value.Length == length)
            return value;
        else
            throw new FormatException("File content invalid !");
    }

    public static string Space(this string input, int value, int maxlength = -1)
    {
        string output = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            if (i > 0)
                for (int j = 0; j < value; j++)
                    output += ' ';
            output += input[i];
        }
        if (maxlength > 0 && output.Length > maxlength)
            return input;
        return output;
    }
}