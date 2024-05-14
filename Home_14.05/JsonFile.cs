using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_14._05
{
    internal class JsonFile <T>
    {
        public static void WriteJsonFile(T obj, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                string json = JsonConvert.SerializeObject(obj);
                sw.WriteLine(json);
            }
        }
        public static T ReadOneObject(string path)
        {
            T obj;
            using (StreamReader sr = new StreamReader(path))
            {
                obj = JsonConvert.DeserializeObject<T>(sr.ReadToEnd());
            }
            return obj;
        }
        public static void WriteJsonFile(List<T> list, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                string json = JsonConvert.SerializeObject(list);
                sw.WriteLine(json);
            }
        }
        public static List<T> ReadObjectList(string path)
        {
            List<T> list = new List<T>();
            using(StreamReader sr = new StreamReader(path))
            {
                list = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
            return list;
        }
    }
}
