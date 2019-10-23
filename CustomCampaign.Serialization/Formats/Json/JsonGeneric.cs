#if SERIALIZER_JSON && (JSON_NEWTONSOFT || JSON_LITJSON)
using System.IO;
#if JSON_NEWTONSOFT
using Newtonsoft.Json;
#endif
#if JSON_LITJSON
using LitJson;
#endif

#pragma warning disable IDE0063, RCS1001, CS0436, CA2202

namespace Photon.Serialization
{
    public sealed class JsonGenericSerializer<SERIALIZER_TYPE> : ISerializer<SERIALIZER_TYPE> where SERIALIZER_TYPE : class, new()
    {
        public void Serialize(SERIALIZER_TYPE DATA, string FilePath)
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);
#if JSON_NEWTONSOFT
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
#endif
#if JSON_LITJSON
            using (StreamWriter FILE_STREAM = new StreamWriter(FilePath))
                FILE_STREAM.WriteLine(JsonMapper.ToJson(DATA));
#endif
        }

        public SERIALIZER_TYPE Deserialize(string FilePath, bool ShowError = true)
        {
            SERIALIZER_TYPE RESULT = null;

            if (!File.Exists(FilePath))
                if (ShowError)
                    throw new FileNotFoundException();
                else
                    return new SERIALIZER_TYPE();
            string SERIALIZED_TEXT = "";
            using (StreamReader READER = new StreamReader(FilePath))
                SERIALIZED_TEXT = READER.ReadToEnd();
#if JSON_NEWTONSOFT
            RESULT = JsonConvert.DeserializeObject<SERIALIZER_TYPE>(SERIALIZED_TEXT);
#endif
#if JSON_LITJSON
            RESULT = JsonMapper.ToObject<SERIALIZER_TYPE>(SERIALIZED_TEXT);
#endif
            return RESULT;
        }
    }
}
#endif