using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Home_14._05
{
    public class ParseToJSON <T>
    {
        public static string ConvertToJson(T obj)
        {
            string res = JsonConvert.SerializeObject(obj);
            return res;
        }

        public static T ConvertFromJson(string json)
        {
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
    }
}
