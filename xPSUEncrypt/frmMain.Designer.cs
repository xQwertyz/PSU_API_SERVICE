namespace xPSUEncrypt
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Encrypt = new System.Windows.Forms.Button();
            this.GB_ENCRYPT_OPTIONS = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_API_KEY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_ByteCodeMode = new System.Windows.Forms.ComboBox();
            this.CB_Premium_Format = new System.Windows.Forms.CheckBox();
            this.CB_Compress_Output = new System.Windows.Forms.CheckBox();
            this.CB_Disable_All_Macros = new System.Windows.Forms.CheckBox();
            this.CB_Disable_Super_Operators = new System.Windows.Forms.CheckBox();
            this.CB_Maximum_Security = new System.Windows.Forms.CheckBox();
            this.CB_Enhanced_Output = new System.Windows.Forms.CheckBox();
            this.CB_Encrypt_All_Strings = new System.Windows.Forms.CheckBox();
            this.TB_SourceFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.GB_ENCRYPT_OPTIONS.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Encrypt
            // 
            this.BTN_Encrypt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_Encrypt.Location = new System.Drawing.Point(15, 235);
            this.BTN_Encrypt.Name = "BTN_Encrypt";
            this.BTN_Encrypt.Size = new System.Drawing.Size(359, 39);
            this.BTN_Encrypt.TabIndex = 0;
            this.BTN_Encrypt.Text = "Encrypt!";
            this.BTN_Encrypt.UseVisualStyleBackColor = true;
            this.BTN_Encrypt.Click += new System.EventHandler(this.BTN_Encrypt_Click);
            // 
            // GB_ENCRYPT_OPTIONS
            // 
            this.GB_ENCRYPT_OPTIONS.Controls.Add(this.label2);
            this.GB_ENCRYPT_OPTIONS.Controls.Add(this.TB_API_KEY);
            this.GB_ENCRYPT_OPTIONS.Controls.Add(this.label1);
            this.GB_ENCRYPT_OPTIONS.Controls.Add(this.CB_ByteCodeMode);
            this.GB_ENCRYPT_OPTIONS.Controls.Add(this.CB_Premium_Format);
            this.GB_ENCRYPT_OPTIONS.Controls.Add(this.CB_Compress_Output);
            this.GB_ENCRYPT_OPTIONS.Controls.Add(this.CB_Disable_All_Macros);
            this.GB_ENCRYPT_OPTIONS.Controls.Add(this.CB_Disable_Super_Operators);
            this.GB_ENCRYPT_OPTIONS.Controls.Add(this.CB_Maximum_Security);
            this.GB_ENCRYPT_OPTIONS.Controls.Add(this.CB_Enhanced_Output);
            this.GB_ENCRYPT_OPTIONS.Controls.Add(this.CB_Encrypt_All_Strings);
            this.GB_ENCRYPT_OPTIONS.Location = new System.Drawing.Point(15, 33);
            this.GB_ENCRYPT_OPTIONS.Name = "GB_ENCRYPT_OPTIONS";
            this.GB_ENCRYPT_OPTIONS.Size = new System.Drawing.Size(357, 196);
            this.GB_ENCRYPT_OPTIONS.TabIndex = 1;
            this.GB_ENCRYPT_OPTIONS.TabStop = false;
            this.GB_ENCRYPT_OPTIONS.Text = "Encrypt Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "API KEY";
            // 
            // TB_API_KEY
            // 
            this.TB_API_KEY.Location = new System.Drawing.Point(6, 162);
            this.TB_API_KEY.Name = "TB_API_KEY";
            this.TB_API_KEY.ReadOnly = true;
            this.TB_API_KEY.Size = new System.Drawing.Size(345, 21);
            this.TB_API_KEY.TabIndex = 2;
            this.TB_API_KEY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ByteCodeMode";
            // 
            // CB_ByteCodeMode
            // 
            this.CB_ByteCodeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ByteCodeMode.FormattingEnabled = true;
            this.CB_ByteCodeMode.Items.AddRange(new object[] {
            "Default",
            "Chinese",
            "Arabic",
            "Korean",
            "Emoji",
            "Emoji 2",
            "Greek",
            "Symbols 1",
            "Symbols 2",
            "Symbols 3"});
            this.CB_ByteCodeMode.Location = new System.Drawing.Point(201, 116);
            this.CB_ByteCodeMode.Name = "CB_ByteCodeMode";
            this.CB_ByteCodeMode.Size = new System.Drawing.Size(121, 21);
            this.CB_ByteCodeMode.TabIndex = 8;
            this.CB_ByteCodeMode.SelectedIndexChanged += new System.EventHandler(this.CB_ByteCodeMode_SelectedIndexChanged);
            // 
            // CB_Premium_Format
            // 
            this.CB_Premium_Format.AutoSize = true;
            this.CB_Premium_Format.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CB_Premium_Format.ForeColor = System.Drawing.Color.Red;
            this.CB_Premium_Format.Location = new System.Drawing.Point(201, 76);
            this.CB_Premium_Format.Name = "CB_Premium_Format";
            this.CB_Premium_Format.Size = new System.Drawing.Size(121, 17);
            this.CB_Premium_Format.TabIndex = 6;
            this.CB_Premium_Format.Text = "Premium Format";
            this.CB_Premium_Format.UseVisualStyleBackColor = true;
            this.CB_Premium_Format.CheckedChanged += new System.EventHandler(this.CB_Premium_Format_CheckedChanged);
            // 
            // CB_Compress_Output
            // 
            this.CB_Compress_Output.AutoSize = true;
            this.CB_Compress_Output.Location = new System.Drawing.Point(201, 53);
            this.CB_Compress_Output.Name = "CB_Compress_Output";
            this.CB_Compress_Output.Size = new System.Drawing.Size(110, 17);
            this.CB_Compress_Output.TabIndex = 5;
            this.CB_Compress_Output.Text = "Compress Output";
            this.CB_Compress_Output.UseVisualStyleBackColor = true;
            this.CB_Compress_Output.CheckedChanged += new System.EventHandler(this.CB_Compress_Output_CheckedChanged);
            // 
            // CB_Disable_All_Macros
            // 
            this.CB_Disable_All_Macros.AutoSize = true;
            this.CB_Disable_All_Macros.Location = new System.Drawing.Point(201, 30);
            this.CB_Disable_All_Macros.Name = "CB_Disable_All_Macros";
            this.CB_Disable_All_Macros.Size = new System.Drawing.Size(111, 17);
            this.CB_Disable_All_Macros.TabIndex = 4;
            this.CB_Disable_All_Macros.Text = "Disable All Macros";
            this.CB_Disable_All_Macros.UseVisualStyleBackColor = true;
            this.CB_Disable_All_Macros.CheckedChanged += new System.EventHandler(this.CB_Disable_All_Macros_CheckedChanged);
            // 
            // CB_Disable_Super_Operators
            // 
            this.CB_Disable_Super_Operators.AutoSize = true;
            this.CB_Disable_Super_Operators.Location = new System.Drawing.Point(19, 99);
            this.CB_Disable_Super_Operators.Name = "CB_Disable_Super_Operators";
            this.CB_Disable_Super_Operators.Size = new System.Drawing.Size(143, 17);
            this.CB_Disable_Super_Operators.TabIndex = 3;
            this.CB_Disable_Super_Operators.Text = "Disable Super Operators";
            this.CB_Disable_Super_Operators.UseVisualStyleBackColor = true;
            this.CB_Disable_Super_Operators.CheckedChanged += new System.EventHandler(this.CB_Disable_Super_Operators_CheckedChanged);
            // 
            // CB_Maximum_Security
            // 
            this.CB_Maximum_Security.AutoSize = true;
            this.CB_Maximum_Security.Location = new System.Drawing.Point(19, 76);
            this.CB_Maximum_Security.Name = "CB_Maximum_Security";
            this.CB_Maximum_Security.Size = new System.Drawing.Size(112, 17);
            this.CB_Maximum_Security.TabIndex = 2;
            this.CB_Maximum_Security.Text = "Maximum Security";
            this.CB_Maximum_Security.UseVisualStyleBackColor = true;
            this.CB_Maximum_Security.CheckedChanged += new System.EventHandler(this.CB_Maximum_Security_CheckedChanged);
            // 
            // CB_Enhanced_Output
            // 
            this.CB_Enhanced_Output.AutoSize = true;
            this.CB_Enhanced_Output.Location = new System.Drawing.Point(19, 53);
            this.CB_Enhanced_Output.Name = "CB_Enhanced_Output";
            this.CB_Enhanced_Output.Size = new System.Drawing.Size(110, 17);
            this.CB_Enhanced_Output.TabIndex = 1;
            this.CB_Enhanced_Output.Text = "Enhanced Output";
            this.CB_Enhanced_Output.UseVisualStyleBackColor = true;
            this.CB_Enhanced_Output.CheckedChanged += new System.EventHandler(this.CB_Enhanced_Output_CheckedChanged);
            // 
            // CB_Encrypt_All_Strings
            // 
            this.CB_Encrypt_All_Strings.AutoSize = true;
            this.CB_Encrypt_All_Strings.Location = new System.Drawing.Point(19, 30);
            this.CB_Encrypt_All_Strings.Name = "CB_Encrypt_All_Strings";
            this.CB_Encrypt_All_Strings.Size = new System.Drawing.Size(113, 17);
            this.CB_Encrypt_All_Strings.TabIndex = 0;
            this.CB_Encrypt_All_Strings.Text = "Encrypt All Strings";
            this.CB_Encrypt_All_Strings.UseVisualStyleBackColor = true;
            this.CB_Encrypt_All_Strings.CheckedChanged += new System.EventHandler(this.CB_Encrypt_All_Strings_CheckedChanged);
            // 
            // TB_SourceFile
            // 
            this.TB_SourceFile.Location = new System.Drawing.Point(77, 6);
            this.TB_SourceFile.Name = "TB_SourceFile";
            this.TB_SourceFile.Size = new System.Drawing.Size(295, 21);
            this.TB_SourceFile.TabIndex = 2;
            this.TB_SourceFile.DoubleClick += new System.EventHandler(this.TB_SourceFile_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Source File";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 283);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(386, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "STATUS_BAR";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(371, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Created By.xZero";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(386, 305);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_SourceFile);
            this.Controls.Add(this.GB_ENCRYPT_OPTIONS);
            this.Controls.Add(this.BTN_Encrypt);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xPSUEncrypt";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.GB_ENCRYPT_OPTIONS.ResumeLayout(false);
            this.GB_ENCRYPT_OPTIONS.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Encrypt;
        private System.Windows.Forms.GroupBox GB_ENCRYPT_OPTIONS;
        private System.Windows.Forms.CheckBox CB_Maximum_Security;
        private System.Windows.Forms.CheckBox CB_Enhanced_Output;
        private System.Windows.Forms.CheckBox CB_Encrypt_All_Strings;
        private System.Windows.Forms.CheckBox CB_Compress_Output;
        private System.Windows.Forms.CheckBox CB_Disable_All_Macros;
        private System.Windows.Forms.CheckBox CB_Disable_Super_Operators;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_ByteCodeMode;
        private System.Windows.Forms.CheckBox CB_Premium_Format;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_API_KEY;
        private System.Windows.Forms.TextBox TB_SourceFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

