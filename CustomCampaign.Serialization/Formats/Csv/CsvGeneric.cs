#if SERIALIZER_CSV
using FileHelpers;
using System.IO;

namespace Photon.Serialization
{
    public sealed class CsvGenericSerializer<SERIALIZER_TYPE> : ISerializer<SERIALIZER_TYPE> where SERIALIZER_TYPE : class, new()
    {
        public void Serialize(SERIALIZER_TYPE DATA, string FilePath)
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);
            
            FileHelperEngine<SERIALIZER_TYPE> ENGINE = new FileHelperEngine<SERIALIZER_TYPE>();
            SERIALIZER_TYPE[] RECORDS = new SERIALIZER_TYPE[1];

            RECORDS[0] = DATA;

            ENGINE.WriteFile(FilePath, RECORDS);
        }

        public SERIALIZER_TYPE Deserialize(string FilePath, bool ShowError = true)
        {
            if (!(File.Exists(FilePath)))
                if (ShowError)
                    throw new FileNotFoundException();
                else
                    return new SERIALIZER_TYPE();
            SERIALIZER_TYPE DESERIALIZED_OBJECT = new SERIALIZER_TYPE();

            FileHelperEngine<SERIALIZER_TYPE> ENGINE = new FileHelperEngine<SERIALIZER_TYPE>();
            SERIALIZER_TYPE[] RECORDS = ENGINE.ReadFile(FilePath);
            DESERIALIZED_OBJECT = RECORDS[0];

            return DESERIALIZED_OBJECT;
        }
    }
}
#endif