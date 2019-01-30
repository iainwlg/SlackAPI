using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackAPI
{
    public class RequestSerializer
    {
        public static IEnumerable<Tuple<string, string>> Serialize<T>(T request)
        {
            var results = new List<Tuple<string, string>>();

            foreach (var prop in typeof(T).GetProperties())
            {
                var val = prop.GetValue(request);

                if (val == null) continue;

                if(prop.PropertyType == typeof(string))
                {
                    results.Add(Tuple.Create(prop.Name, val.ToString()));
                }
                if(prop.PropertyType == typeof(bool))
                {
                    var value = (bool)val;
                    results.Add(Tuple.Create(prop.Name, value ? "1" : "0"));
                }
                if(prop.PropertyType.IsEnum)
                {
                    results.Add(Tuple.Create(prop.Name, val.ToString()));
                }
                if(prop.PropertyType.IsClass)
                {
                    results.Add(Tuple.Create(prop.Name, JsonConvert.SerializeObject(val)));
                }
            }

            return results;
        }
    }
}
