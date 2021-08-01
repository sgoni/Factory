using Newtonsoft.Json;

namespace FactoryStandard
{
    public static class JSONHelper
    {
        public static string SerializeObject<T>(this T toSerialize)
        {
            string jsonData = JsonConvert.SerializeObject(toSerialize);
            return jsonData;
        }

        public static object SerializeObject<T>(string value)
        {
            object _obj = JsonConvert.DeserializeObject<T>(value);
            return _obj;
        }
    }
}