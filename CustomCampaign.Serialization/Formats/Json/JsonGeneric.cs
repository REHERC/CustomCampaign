#if SERIALIZER_JSON
using System.IO;
using Newtonsoft.Json;

#pragma warning disable RCS1001
namespace Photon.Serialization
{
    public sealed class JsonGenericSerializer<SERIALIZER_TYPE> : ISerializer<SERIALIZER_TYPE> where SERIALIZER_TYPE : class, new()
    {
        public void Serialize(SERIALIZER_TYPE DATA, string FilePath)
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);
            JsonSerializer SERIALIZER = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Include,
            };
            using (StreamWriter FILE_STREAM = new StreamWriter(FilePath))
                using (JsonWriter JSON_WRITER = new JsonTextWriter(FILE_STREAM))
                {
                    JSON_WRITER.Formatting = Formatting.Indented;
                    SERIALIZER.Serialize(JSON_WRITER, DATA);
                }
        }

        public SERIALIZER_TYPE Deserialize(string FilePath, bool ShowError = true)
        {
            if (!File.Exists(FilePath))
                if (ShowError)
                    throw new FileNotFoundException();
                else
                    return new SERIALIZER_TYPE();
            string SERIALIZED_TEXT = "";
            using (StreamReader READER = new StreamReader(FilePath))
                SERIALIZED_TEXT = READER.ReadToEnd();
            return JsonConvert.DeserializeObject<SERIALIZER_TYPE>(SERIALIZED_TEXT);
        }
    }
}
#endif