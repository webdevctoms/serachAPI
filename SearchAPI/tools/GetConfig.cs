using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAPI.tools
{
    public class GetConfig
    {
        public string Pass { get; set; }
        public string Username { get; set; }
        public string Url { get; set; }
        private string PassString = "pass";
        private string UserString = "username";
        private string UrlString = "url";
        public GetConfig()
        {
            Dictionary<string, string> configData =  GetData();
            Pass = configData[PassString];
            Username = configData[UserString];
            Url = configData[UrlString];
        }

        private Dictionary<string,string> GetData()
        {
            Dictionary<string, string> configData = new Dictionary<string, string>();

            using (StreamReader sr = new StreamReader("config.json"))
            {
                string json = sr.ReadToEnd();
                //dynamic since data will be populated at run time
                dynamic data = JsonConvert.DeserializeObject(json);
                configData.Add(PassString,Convert.ToString(data.pass));
                configData.Add(UserString, Convert.ToString(data.username));
                configData.Add(UrlString, Convert.ToString(data.url));
            }

            return configData;

        }
    }
}
