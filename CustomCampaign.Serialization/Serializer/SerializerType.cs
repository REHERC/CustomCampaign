namespace Photon.Serialization
{
    public enum SerializerType
    {
#if SERIALIZER_XML
        Xml,
#endif
#if SERIALIZER_JSON
        Json,
#endif
#if SERIALIZER_BIN
        Bin,
#endif
#if SERIALIZER_YAML
        Yaml,
#endif
#if SERIALIZER_CSV
        Csv
#endif
    }
}
