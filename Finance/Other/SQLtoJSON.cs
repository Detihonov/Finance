using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Finance.Other
{
    class SQLtoJSON
    {
       
        public static void FileConvert()
        {
            var jsonPath = "data.json";
            var jsonData = File.ReadAllText(jsonPath);
            var records = JsonConverter.DeserializeObject<List<TrafficRecord>>(jsonData);
        }


    }

    class TrafficRecord
    {
        public string date_time { get; set; }
        public int traffic_volume { get; set; }
        public double temp { get; set; }
        public double total { get; set; }
        public double snow { get; set; }
        public int clouds { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
