#pragma warning disable CS0436, CS0162, CA1051
using System;

namespace Photon.Serialization
{
    public class Serializer<DATATYPE> : ICloneable where DATATYPE : class, new()
    {
        public string FileName { get; }
        public DATATYPE Data;
        private readonly ISerializer<DATATYPE> DataSerializer;

        public Serializer(SerializerType Type, string FileName, bool LoadOnCtor = false, bool AbsolutePath = true)
        {
            switch (Type)
            {
#if SERIALIZER_XML
                case SerializerType.Xml:
                    DataSerializer = new XmlGenericSerializer<DATA_TYPE>();
                    break;
#endif
#if SERIALIZER_JSON && (JSON_NEWTONSOFT || JSON_LITJSON)
                case SerializerType.Json:
                    DataSerializer = new JsonGenericSerializer<DATATYPE>();
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
                this.FileName = $@"{StartPath}\{FileName}.{Type.ToString().ToLowerInvariant()}";
            }
            else
            {
                this.FileName = FileName;
            }

            if (LoadOnCtor)
            {
                Load();
            }
            else
            {
                Data = new DATATYPE();
            }
        }

        public void Save()
        {
            DataSerializer.Serialize(Data, FileName);
        }

        public void Load()
        {
            Data = DataSerializer.Deserialize(FileName, false);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
