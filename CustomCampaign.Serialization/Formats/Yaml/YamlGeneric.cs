#if SERIALIZER_YAML
using System.IO;
using YamlDotNet.Serialization.NamingConventions;

namespace Photon.Serialization
{
    public sealed class YamlGenericSerializer<SERIALIZER_TYPE> : ISerializer<SERIALIZER_TYPE> where SERIALIZER_TYPE : class, new()
    {
        public void Serialize(SERIALIZER_TYPE DATA, string FilePath)
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);

            YamlDotNet.Serialization.ISerializer SERIALIZER = new YamlDotNet.Serialization.SerializerBuilder()
                .Build();

            using (StreamWriter YAML_STREAM = new StreamWriter(FilePath))
            {
                SERIALIZER.Serialize(YAML_STREAM, (SERIALIZER_TYPE)DATA);
            } 
        }

        public SERIALIZER_TYPE Deserialize(string FilePath, bool ShowError = true)
        {
            if (!(File.Exists(FilePath)))
                if (ShowError)
                    throw new FileNotFoundException();
                else
                    return new SERIALIZER_TYPE();
            SERIALIZER_TYPE DESERIALIZED_OBJECT = new SERIALIZER_TYPE();

            YamlDotNet.Serialization.Deserializer DESERIALIZER = new YamlDotNet.Serialization.Deserializer();
            using (TextReader YAML_STREAM = new StreamReader(FilePath))
            {
                DESERIALIZED_OBJECT = DESERIALIZER.Deserialize<SERIALIZER_TYPE>(YAML_STREAM);
            }
            return DESERIALIZED_OBJECT;
        }
    }
}
#endif