namespace Arma_Launcher
{
    partial class Settings
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
			this.btnSettingsSave = new System.Windows.Forms.Button();
			this.btnSettingsCancel = new System.Windows.Forms.Button();
			this.cpuCoreCount = new System.Windows.Forms.ComboBox();
			this.windowedCHK = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.empty_worldCHK = new System.Windows.Forms.CheckBox();
			this.no_pauseCHK = new System.Windows.Forms.CheckBox();
			this.no_splashCHK = new System.Windows.Forms.CheckBox();
			this.serverIP = new System.Windows.Forms.TextBox();
			this.serverPort = new System.Windows.Forms.TextBox();
			this.ctsChk = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnSettingsSave
			// 
			this.btnSettingsSave.Location = new System.Drawing.Point(137, 184);
			this.btnSettingsSave.Name = "btnSettingsSave";
			this.btnSettingsSave.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsSave.TabIndex = 10;
			this.btnSettingsSave.Text = "Save";
			this.btnSettingsSave.UseVisualStyleBackColor = true;
			this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
			// 
			// btnSettingsCancel
			// 
			this.btnSettingsCancel.Location = new System.Drawing.Point(56, 184);
			this.btnSettingsCancel.Name = "btnSettingsCancel";
			this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsCancel.TabIndex = 9;
			this.btnSettingsCancel.Text = "Cancel";
			this.btnSettingsCancel.UseVisualStyleBackColor = true;
			this.btnSettingsCancel.Click += new System.EventHandler(this.btnSettingsCancel_Click);
			// 
			// cpuCoreCount
			// 
			this.cpuCoreCount.FormattingEnabled = true;
			this.cpuCoreCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.cpuCoreCount.Location = new System.Drawing.Point(77, 103);
			this.cpuCoreCount.Name = "cpuCoreCount";
			this.cpuCoreCount.Size = new System.Drawing.Size(135, 21);
			this.cpuCoreCount.TabIndex = 5;
			this.cpuCoreCount.Text = "4";
			// 
			// windowedCHK
			// 
			this.windowedCHK.AutoSize = true;
			this.windowedCHK.Location = new System.Drawing.Point(12, 81);
			this.windowedCHK.Name = "windowedCHK";
			this.windowedCHK.Size = new System.Drawing.Size(77, 17);
			this.windowedCHK.TabIndex = 4;
			this.windowedCHK.Text = "Windowed";
			this.windowedCHK.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "CPU Cores";
			// 
			// empty_worldCHK
			// 
			this.empty_worldCHK.AutoSize = true;
			this.empty_worldCHK.Location = new System.Drawing.Point(12, 58);
			this.empty_worldCHK.Name = "empty_worldCHK";
			this.empty_worldCHK.Size = new System.Drawing.Size(86, 17);
			this.empty_worldCHK.TabIndex = 3;
			this.empty_worldCHK.Text = "Empty World";
			this.empty_worldCHK.UseVisualStyleBackColor = true;
			// 
			// no_pauseCHK
			// 
			this.no_pauseCHK.AutoSize = true;
			this.no_pauseCHK.Location = new System.Drawing.Point(12, 35);
			this.no_pauseCHK.Name = "no_pauseCHK";
			this.no_pauseCHK.Size = new System.Drawing.Size(73, 17);
			this.no_pauseCHK.TabIndex = 2;
			this.no_pauseCHK.Text = "No Pause";
			this.no_pauseCHK.UseVisualStyleBackColor = true;
			// 
			// no_splashCHK
			// 
			this.no_splashCHK.AutoSize = true;
			this.no_splashCHK.Location = new System.Drawing.Point(12, 12);
			this.no_splashCHK.Name = "no_splashCHK";
			this.no_splashCHK.Size = new System.Drawing.Size(75, 17);
			this.no_splashCHK.TabIndex = 1;
			this.no_splashCHK.Text = "No Splash";
			this.no_splashCHK.UseVisualStyleBackColor = true;
			// 
			// serverIP
			// 
			this.serverIP.Enabled = false;
			this.serverIP.Location = new System.Drawing.Point(12, 158);
			this.serverIP.Name = "serverIP";
			this.serverIP.Size = new System.Drawing.Size(146, 20);
			this.serverIP.TabIndex = 7;
			// 
			// serverPort
			// 
			this.serverPort.Enabled = false;
			this.serverPort.Location = new System.Drawing.Point(164, 158);
			this.serverPort.Name = "serverPort";
			this.serverPort.Size = new System.Drawing.Size(48, 20);
			this.serverPort.TabIndex = 8;
			// 
			// ctsChk
			// 
			this.ctsChk.AutoSize = true;
			this.ctsChk.Location = new System.Drawing.Point(12, 139);
			this.ctsChk.Name = "ctsChk";
			this.ctsChk.Size = new System.Drawing.Size(112, 17);
			this.ctsChk.TabIndex = 6;
			this.ctsChk.Text = "Connect to Server";
			this.ctsChk.UseVisualStyleBackColor = true;
			this.ctsChk.CheckedChanged += new System.EventHandler(this.ctsChk_CheckedChanged);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 215);
			this.Controls.Add(this.ctsChk);
			this.Controls.Add(this.serverPort);
			this.Controls.Add(this.serverIP);
			this.Controls.Add(this.cpuCoreCount);
			this.Controls.Add(this.windowedCHK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.empty_worldCHK);
			this.Controls.Add(this.no_pauseCHK);
			this.Controls.Add(this.no_splashCHK);
			this.Controls.Add(this.btnSettingsCancel);
			this.Controls.Add(this.btnSettingsSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.Settings_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.Button btnSettingsCancel;
        private System.Windows.Forms.ComboBox cpuCoreCount;
        private System.Windows.Forms.CheckBox windowedCHK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox empty_worldCHK;
        private System.Windows.Forms.CheckBox no_pauseCHK;
        private System.Windows.Forms.CheckBox no_splashCHK;
        private System.Windows.Forms.TextBox serverIP;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.CheckBox ctsChk;
    }
}