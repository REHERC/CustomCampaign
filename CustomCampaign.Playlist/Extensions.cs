using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#pragma warning disable CS1591
public static class Extensions
{
    public static string Cipher(this string input, int key)
    {
        string output = string.Empty;

        foreach (char ch in input)
            output += (char)(ch - (key % 32));

        return output;
    }

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
        {
            return value;
        }
        else
        {
            throw new FormatException("File content invalid !");
        }
    }
}