using System;

namespace CustomCampaign.Models
{
    //This class is meant to encapsulate a type so that multiples instances of it can be used as a key for a dictionary (but with a different GUID)
    public class ObjectWithGUID<T>
    {
        protected T value;
        protected Guid guid;

        public T Object => value;

        public ObjectWithGUID(T value)
        {
            this.value = value;
            guid = Guid.NewGuid();
        }

        public Guid GetGuid() => guid;

        // Valid format parameters are N, D, B, P and X
        // https://stackoverflow.com/questions/1700361/how-to-convert-a-guid-to-a-string-in-c
        public string GetGuid(string format = "D") => GetGuid().ToString(format);

        public static ObjectWithGUID<T> Create(T value) => new ObjectWithGUID<T>(value);

        public static implicit operator T (ObjectWithGUID<T> instance) => instance.value;
    }
}
