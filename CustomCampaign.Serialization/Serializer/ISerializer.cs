namespace Photon.Serialization
{
    public interface ISerializer<SERIALIZER_TYPE> where SERIALIZER_TYPE : class, new()
    {
        void Serialize(SERIALIZER_TYPE DATA, string FilePath);

        SERIALIZER_TYPE Deserialize(string FilePath, bool ShowError = true);
    }
}
