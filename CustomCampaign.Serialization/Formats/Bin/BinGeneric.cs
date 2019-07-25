#if SERIALIZER_BIN
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;

namespace Photon.Serialization
{
    public sealed class BinGenericSerializer<SERIALIZER_TYPE> : ISerializer<SERIALIZER_TYPE> where SERIALIZER_TYPE : class, new()
    {
        public void Serialize(SERIALIZER_TYPE DATA, string FilePath)
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);
            IFormatter FORMATTER = new BinaryFormatter();
            using (Stream BIN_STREAM = new FileStream(FilePath, FileMode.Create, FileAccess.Write))
            {
                FORMATTER.Serialize(BIN_STREAM, DATA);
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

            IFormatter FORMATTER = new BinaryFormatter();
            using (Stream BIN_STREAM = new FileStream(FilePath, FileMode.Open))
            {
                DESERIALIZED_OBJECT = (SERIALIZER_TYPE)FORMATTER.Deserialize(BIN_STREAM);
            }
            return DESERIALIZED_OBJECT;
        }
    }
}
#endif