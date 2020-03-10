using System.IO;
using System.Xml.Serialization;

namespace Prototype
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            using(var memoryStream = new MemoryStream())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(memoryStream, self);
                memoryStream.Position = 0;
                return (T)serializer.Deserialize(memoryStream);
            }
        }
    }
}
