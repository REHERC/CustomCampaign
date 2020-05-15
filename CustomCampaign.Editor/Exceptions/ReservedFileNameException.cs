using System;
using System.Runtime.Serialization;

namespace CustomCampaign.Editor.Exceptions
{
    [Serializable]
    public class ReservedFileNameException : Exception
    {
        public ReservedFileNameException() : base("The file path provided contains a name reserved by the file system.")
        {
        }

        protected ReservedFileNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ReservedFileNameException(string message) : base(message)
        {
        }

        public ReservedFileNameException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
