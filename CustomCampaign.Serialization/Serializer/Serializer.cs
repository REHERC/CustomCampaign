using System;

namespace Photon.Serialization
{
    public class Serializer<DATA_TYPE> : ICloneable where DATA_TYPE : class, new()
    {
        private readonly string FilePath;
        public DATA_TYPE Data;
        private readonly ISerializer<DATA_TYPE> DataSerializer;

        public Serializer(SerializerType Type, string FileName, bool LoadOnCtor = false, bool AbsolutePath = true)
        {
            switch (Type)
            {
#if SERIALIZER_XML
                case SerializerType.Xml:
                    DataSerializer = new XmlGenericSerializer<DATA_TYPE>();
                    break;
#endif
#if SERIALIZER_JSON
                case SerializerType.Json:
                    DataSerializer = new JsonGenericSerializer<DATA_TYPE>();
                    break;
#endif
#if SERIALIZER_BIN
                case SerializerType.Bin:
                    DataSerializer = new BinGenericSerializer<DATA_TYPE>();
                    break;
#endif
#if SERIALIZER_YAML
                case SerializerType.Yaml:
                    DataSerializer = new YamlGenericSerializer<DATA_TYPE>();
                    break;
#endif
#if SERIALIZER_CSV
                case SerializerType.Csv:
                    DataSerializer = new CsvGenericSerializer<DATA_TYPE>();
                    break;
#endif
                default:
                    DataSerializer = null;
                    Data = null;
                    return;
            }

            if (!AbsolutePath)
            {
                string StartPath = AppDomain.CurrentDomain.BaseDirectory;
                FilePath = $@"{StartPath}\{FileName}.{Type.ToString().ToLowerInvariant()}";
            }
            else
            {
                FilePath = FileName;
            }

            if (LoadOnCtor)
                Load();
            else
                Data = new DATA_TYPE();
        }

        public void Save()
        {
            DataSerializer.Serialize(Data, FilePath);
        }

        public void Load()
        {
            Data = DataSerializer.Deserialize(FilePath, false);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
