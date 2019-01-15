#if SERIALIZER_XML
using System.IO;
using System.Xml.Serialization;

namespace Photon.Serialization
{
    public sealed class XmlGenericSerializer<SERIALIZER_TYPE> : ISerializer<SERIALIZER_TYPE> where SERIALIZER_TYPE : class, new()
    {
        public void Serialize(SERIALIZER_TYPE DATA, string FilePath)
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);
            XmlSerializer SERIALIZER = new XmlSerializer(DATA.GetType());
            using (FileStream FILE_STREAM = new FileStream(FilePath, FileMode.Create))
            {
                SERIALIZER.Serialize(FILE_STREAM, DATA);
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
            string SERIALIZED_TEXT = "";
            using (StreamReader READER = new StreamReader(FilePath))
            {
                SERIALIZED_TEXT = READER.ReadToEnd();
            }
            XmlSerializer SERIALIZER = new XmlSerializer(DESERIALIZED_OBJECT.GetType());
            using (TextReader READER = new StringReader(SERIALIZED_TEXT))
            {
                DESERIALIZED_OBJECT = (SERIALIZER_TYPE)SERIALIZER.Deserialize(READER);
            }
            return DESERIALIZED_OBJECT;
        }
    }
}
#endif