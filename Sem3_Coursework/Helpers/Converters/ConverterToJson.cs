using System;
using Newtonsoft.Json;

namespace Sem3_Coursework.Helpers
{
    public static class ConverterToJson
    {
        static public string ConvertToJson(object value)
        {
            if (value is null) throw new ArgumentNullException();
            return JsonConvert.SerializeObject(value);
        }
        static public object ConvertFromJson(string value)
        {
            return JsonConvert.DeserializeObject(value);
        }
    }
}
