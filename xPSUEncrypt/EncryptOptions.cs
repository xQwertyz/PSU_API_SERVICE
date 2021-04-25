using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace xPSUEncrypt
{
    public class EncryptOptions
    {
        public static void Init()
        {
            Config.API_KEY = Convert.ToString(Config.encryptOptionsJObject["key"]);
            JToken options = Config.encryptOptionsJObject["options"];
            frmMain.encryptOptions = new EncryptOptions();
            frmMain.encryptOptions.DisableSuperOperators = Convert.ToBoolean(options["DisableSuperOperators"]);
            frmMain.encryptOptions.MaximumSecurityEnabled = Convert.ToBoolean(options["MaximumSecurityEnabled"]);
            frmMain.encryptOptions.EncryptAllStrings = Convert.ToBoolean(options["EncryptAllStrings"]);
            frmMain.encryptOptions.DisableAllMacros = Convert.ToBoolean(options["DisableAllMacros"]);
            frmMain.encryptOptions.EnhancedOutput = Convert.ToBoolean(options["EnhancedOutput"]);
            frmMain.encryptOptions.CompressedOutput = Convert.ToBoolean(options["CompressedOutput"]);
            frmMain.encryptOptions.PremiumFormat = Convert.ToBoolean(options["PremiumFormat"]);
            frmMain.encryptOptions.ByteCodeMode = Convert.ToString(options["ByteCodeMode"]);
        }

        public bool DisableSuperOperators { get; set; }
        public bool MaximumSecurityEnabled { get; set; }
        public bool EncryptAllStrings { get; set; }
        public bool DisableAllMacros { get; set; }
        public bool EnhancedOutput { get; set; }
        public bool CompressedOutput { get; set; }
        public bool PremiumFormat { get; set; }
        public string ByteCodeMode { get; set; }

        public JObject GetOptionsJObject()
        {
            JObject options = new JObject();
            options.Add("DisableSuperOperators", this.DisableSuperOperators);
            options.Add("MaximumSecurityEnabled", this.MaximumSecurityEnabled);
            options.Add("EncryptAllStrings", this.EncryptAllStrings);
            options.Add("DisableAllMacros", this.DisableAllMacros);
            options.Add("EnhancedOutput", this.EnhancedOutput);
            options.Add("CompressedOutput", this.CompressedOutput);
            options.Add("PremiumFormat", this.PremiumFormat);
            options.Add("ByteCodeMode", this.ByteCodeMode);
            return options;
        }

        public string GetRequestData(string script = "")
        {
            JObject requestData = new JObject();
            requestData.Add("key", Config.API_KEY);
            requestData.Add("script", script);
            requestData.Add("options", this.GetOptionsJObject());
            return requestData.ToString();
        }

        public bool SaveOptions()
        {
            try
            {
                Config.encryptOptionsJObject["options"] = this.GetOptionsJObject();
                File.WriteAllText(Config.ROOT_PATH + "encryptOptions.json", Config.encryptOptionsJObject.ToString());
                Funcs.CleanMemory();
                return true;
            }
            catch { }
            return false;
        }
    }
}
