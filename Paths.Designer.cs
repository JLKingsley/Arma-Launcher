namespace Arma_Launcher
{
    partial class Paths
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
            this.label1 = new System.Windows.Forms.Label();
            this.arma2Path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.arma2OAPath = new System.Windows.Forms.TextBox();
            this.btnPathsSave = new System.Windows.Forms.Button();
            this.btnPathsCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArmA 2";
            // 
            // arma2Path
            // 
            this.arma2Path.Location = new System.Drawing.Point(77, 6);
            this.arma2Path.Name = "arma2Path";
            this.arma2Path.Size = new System.Drawing.Size(257, 20);
            this.arma2Path.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ArmA 2 OA";
            // 
            // arma2OAPath
            // 
            this.arma2OAPath.Location = new System.Drawing.Point(77, 35);
            this.arma2OAPath.Name = "arma2OAPath";
            this.arma2OAPath.Size = new System.Drawing.Size(257, 20);
            this.arma2OAPath.TabIndex = 2;
            // 
            // btnPathsSave
            // 
            this.btnPathsSave.Location = new System.Drawing.Point(259, 61);
            this.btnPathsSave.Name = "btnPathsSave";
            this.btnPathsSave.Size = new System.Drawing.Size(75, 23);
            this.btnPathsSave.TabIndex = 4;
            this.btnPathsSave.Text = "Save";
            this.btnPathsSave.UseVisualStyleBackColor = true;
            this.btnPathsSave.Click += new System.EventHandler(this.btnPathsSave_Click);
            // 
            // btnPathsCancel
            // 
            this.btnPathsCancel.Location = new System.Drawing.Point(178, 61);
            this.btnPathsCancel.Name = "btnPathsCancel";
            this.btnPathsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnPathsCancel.TabIndex = 3;
            this.btnPathsCancel.Text = "Cancel";
            this.btnPathsCancel.UseVisualStyleBackColor = true;
            this.btnPathsCancel.Click += new System.EventHandler(this.btnPathsCancel_Click);
            // 
            // Paths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 95);
            this.Controls.Add(this.btnPathsCancel);
            this.Controls.Add(this.btnPathsSave);
            this.Controls.Add(this.arma2OAPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arma2Path);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paths";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paths";
            this.Load += new System.EventHandler(this.Paths_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arma2Path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arma2OAPath;
        private System.Windows.Forms.Button btnPathsSave;
        private System.Windows.Forms.Button btnPathsCancel;
    }
}