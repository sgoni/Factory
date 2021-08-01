using System.IO;
using System.Xml.Serialization;

namespace FactoryStandard
{
    public static class SerializationHelper
    {
        public static T Deserialize<T>(this string toDeserialize)
        {
            // Create an instance of the XmlSerializer.
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (StringReader textReader = new StringReader(toDeserialize))
            {
                // Call the Deserialize method to restore the object's state.
                return (T)xmlSerializer.Deserialize(textReader);
            }
        }

        public static T DeserializeObject<T>(string filename, string _xmlRootAttribute)
        {
            // Create an instance of the XmlSerializer.
            XmlSerializer serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(_xmlRootAttribute));

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                return (T)serializer.Deserialize(reader);
            }
        }

        public static string Serialize<T>(this T toSerialize)
        {
            // Create an instance of the XmlSerializer.
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }
    }
}
