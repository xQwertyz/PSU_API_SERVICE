using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace xPSUEncrypt
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static bool firstRun = true;
        public static EncryptOptions encryptOptions = null;

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.Text = Config.TITLE;
            this.CB_ByteCodeMode.Text = "Default";
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Config.encryptOptionsJObject = Funcs.GetJObjectFromFile($"{Config.ROOT_PATH}encryptOptions.json");
            if (Config.encryptOptionsJObject == null)
            {
                MessageBox.Show("Error GetJObject encryptOptionsJObject", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Funcs.Exit();
                return;
            }
            EncryptOptions.Init();
            this.CB_Disable_Super_Operators.Checked = encryptOptions.DisableSuperOperators;
            this.CB_Maximum_Security.Checked = encryptOptions.MaximumSecurityEnabled;
            this.CB_Encrypt_All_Strings.Checked = encryptOptions.EncryptAllStrings;
            this.CB_Disable_All_Macros.Checked = encryptOptions.DisableAllMacros;
            this.CB_Enhanced_Output.Checked = encryptOptions.EnhancedOutput;
            this.CB_Compress_Output.Checked = encryptOptions.CompressedOutput;
            this.CB_Premium_Format.Checked = encryptOptions.PremiumFormat;
            this.CB_ByteCodeMode.Text = encryptOptions.ByteCodeMode;
            this.TB_API_KEY.Text = Config.API_KEY;
            firstRun = false;
            Funcs.CleanMemory();
        }

        private void BTN_Encrypt_Click(object sender, EventArgs e)
        {
            if (!File.Exists(TB_SourceFile.Text))
            {
                MessageBox.Show("Error NotFound OpenFile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            encryptOptions.SaveOptions();
            string getSourceFile = Funcs.RealFileText(this.TB_SourceFile.Text);
            string RequestEncrypt = Funcs.HttpPost(Config.URL_API_PSU, encryptOptions.GetRequestData(getSourceFile));
            if (RequestEncrypt == null)
            {
                Funcs.CleanMemory();
                MessageBox.Show("Error RequestEncrypt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string savePath = OpenDialogFile(false, true);
                if(savePath == null)
                {
                    Funcs.CleanMemory();
                    MessageBox.Show("Error GetSavePath", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                File.WriteAllText(savePath, JObject.Parse(RequestEncrypt)["data"].ToString());
                MessageBox.Show("Success", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SaveEncryptFile" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Funcs.CleanMemory();
        }

        private void TB_SourceFile_DoubleClick(object sender, EventArgs e)
        {
            TB_SourceFile.Text = OpenDialogFile();
        }

        private string OpenDialogFile(bool _checkFileExists = true, bool _checkPathExists = true)
        {
            string result = null;
            using (OpenFileDialog OFD = new OpenFileDialog
            {
                Title = "OpenDialogFile",
                CheckFileExists = _checkFileExists,
                CheckPathExists = _checkPathExists,
                DefaultExt = "lua",
                Filter = "Lua File |*.lua"
            })
            {
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    result = OFD.FileName;
                }
            }
            return result;
        }

        #region UI Options Changed Update
        private void CB_Encrypt_All_Strings_CheckedChanged(object sender, EventArgs e)
        {
            if (firstRun) return;
            encryptOptions.EncryptAllStrings = this.CB_Encrypt_All_Strings.Checked;
        }

        private void CB_Enhanced_Output_CheckedChanged(object sender, EventArgs e)
        {
            if (firstRun) return;
            encryptOptions.EnhancedOutput = this.CB_Enhanced_Output.Checked;
        }

        private void CB_Maximum_Security_CheckedChanged(object sender, EventArgs e)
        {
            if (firstRun) return;
            encryptOptions.MaximumSecurityEnabled = this.CB_Maximum_Security.Checked;
        }

        private void CB_Disable_Super_Operators_CheckedChanged(object sender, EventArgs e)
        {
            if (firstRun) return;
            encryptOptions.DisableSuperOperators = this.CB_Disable_Super_Operators.Checked;
        }

        private void CB_Disable_All_Macros_CheckedChanged(object sender, EventArgs e)
        {
            if (firstRun) return;
            encryptOptions.DisableAllMacros = this.CB_Disable_All_Macros.Checked;
        }

        private void CB_Compress_Output_CheckedChanged(object sender, EventArgs e)
        {
            if (firstRun) return;
            encryptOptions.CompressedOutput = this.CB_Compress_Output.Checked;
        }

        private void CB_Premium_Format_CheckedChanged(object sender, EventArgs e)
        {
            if (firstRun) return;
            encryptOptions.PremiumFormat = this.CB_Premium_Format.Checked;
        }

        private void CB_ByteCodeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstRun) return;
            encryptOptions.ByteCodeMode = this.CB_ByteCodeMode.Text;
        }
        #endregion
    }
}
