using System;
using System.IO;
using System.Reflection;

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
        if (input is null || input == "" || input == string.Empty) return "";
        bool directory = !file || input.EndsWith(Path.DirectorySeparatorChar) || input.EndsWith(Path.AltDirectorySeparatorChar);
        while (output.Contains("//"))
            output = output.Replace("//", "/");
        return output + (directory ? "/" : "").ToString();
    }

    public static void MakeDirectory(string directory)
    {
        if (!Directory.Exists(directory))
            Directory.CreateDirectory(directory);
    }

    public static void CopyFile(string source, string destination, bool overwrite = true)
    {
        if (File.Exists(source))
            File.Copy(source, destination, overwrite);
    }
}

// Code from here
// https://www.codeproject.com/Articles/80343/Accessing-private-members

public static class PrivateAccess
{
    public static T GetPrivateField<T>(this object obj, string name)
    {
        BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = obj.GetType();
        FieldInfo field = type.GetField(name, flags);
        return (T)field.GetValue(obj);
    }

    public static T GetPrivateProperty<T>(this object obj, string name)
    {
        BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = obj.GetType();
        PropertyInfo field = type.GetProperty(name, flags);
        return (T)field.GetValue(obj, null);
    }

    public static void SetPrivateField(this object obj, string name, object value)
    {
        BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = obj.GetType();
        FieldInfo field = type.GetField(name, flags);
        field.SetValue(obj, value);
    }

    public static void SetPrivateProperty(this object obj, string name, object value)
    {
        BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = obj.GetType();
        PropertyInfo field = type.GetProperty(name, flags);
        field.SetValue(obj, value, null);
    }

    public static T CallPrivateFunction<T>(this object obj, string name, params object[] param)
    {
        BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(name, flags);
        return (T)method.Invoke(obj, param);
    }

    public static void CallPrivateMethod(this object obj, string name, params object[] param)
    {
        BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(name, flags);
        method.Invoke(obj, param);
    }
}