using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace xPSUEncrypt
{
    public static class Funcs
    {
        public static void Exit()
        {
            try
            {
                Process.GetCurrentProcess().Kill();
            }
            catch { }
        }

        public static bool AcceptAllCertifications(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslpolicyerrors)
        {
            return true;
        }

        public static string HttpPost(string url, string data)
        {
            string result = null;
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072 | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(AcceptAllCertifications);
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    result =  wc.UploadString(url, "POST", data);
                }
            }
            catch { }
            return result;
        }

        public static string RealFileText(string path)
        {
            string result = null;
            try
            {
                result = File.ReadAllText(path);
            }
            catch { }
            return result;
        }

        public static JObject GetJObjectFromFile(string path)
        {
            try
            {
                return JObject.Parse(File.ReadAllText(path));
            }
            catch { }
            return null;
        }

        public static void CleanMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
