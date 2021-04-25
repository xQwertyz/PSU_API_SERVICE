using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace xPSUEncrypt
{
    public static class Config
    {
        public static string TITLE = "PSU API SERVICE [BUILD 25/04/2564]";
        public static string ROOT_PATH = Environment.CurrentDirectory + @"\";
        public static string URL_API_PSU = "https://api.psu.dev/obfuscate";
        public static string API_KEY = "";

        public static JObject encryptOptionsJObject = null;
    }
}
