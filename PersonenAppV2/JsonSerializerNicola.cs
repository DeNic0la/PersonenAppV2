using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PersonenAppV2.Properties;

namespace PersonenAppV2 {
    class JsonSerializerNicola {

        public void JsonSerialize(object data, string filepath) {
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filepath)) { File.Delete(filepath); }
            StreamWriter sw = new StreamWriter(filepath);
            JsonWriter jsonWriter = new JsonTextWriter(sw);

            jsonSerializer.Serialize(jsonWriter, data);
            jsonWriter.Close();
            sw.Close();
        }
        public object JsonDesirialize(Type dataType, string filepath) {
            Object obj = null;
            JsonSerializer jsonSerializer = new JsonSerializer();
            //if (File.Exists(filepath)) {
                StreamReader sr = new StreamReader(filepath);
                JsonReader jr = new JsonTextReader(sr);
                obj = jsonSerializer.Deserialize(jr);
                jr.Close();
                sr.Close();
                
            //}
            

            return obj;
        }
    }
}
