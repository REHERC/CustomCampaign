namespace CustomCampaign.Data
{
    public interface IData
    {
        int DataVersion { get; }
        string DataName { get; }
        string DataDescription { get; }
        void VisitData(IVisitor visitor, ISerializable prefabComp, int version);
        string DataIdentifier { get; }
    }
}
