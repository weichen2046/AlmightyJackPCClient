namespace AlmightyJackPCClient
{
    partial class SettingsForm
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
            this.btnSetOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPhonePort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPCPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSetOK
            // 
            this.btnSetOK.Location = new System.Drawing.Point(113, 125);
            this.btnSetOK.Name = "btnSetOK";
            this.btnSetOK.Size = new System.Drawing.Size(75, 23);
            this.btnSetOK.TabIndex = 0;
            this.btnSetOK.Text = "设置";
            this.btnSetOK.UseVisualStyleBackColor = true;
            this.btnSetOK.Click += new System.EventHandler(this.btnSetOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "手机端监听端口：";
            // 
            // txbPhonePort
            // 
            this.txbPhonePort.Location = new System.Drawing.Point(153, 55);
            this.txbPhonePort.Name = "txbPhonePort";
            this.txbPhonePort.Size = new System.Drawing.Size(100, 21);
            this.txbPhonePort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PC端监听端口：";
            // 
            // txbPCPort
            // 
            this.txbPCPort.Location = new System.Drawing.Point(153, 82);
            this.txbPCPort.Name = "txbPCPort";
            this.txbPCPort.Size = new System.Drawing.Size(100, 21);
            this.txbPCPort.TabIndex = 2;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 203);
            this.Controls.Add(this.txbPCPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPhonePort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetOK);
            this.Name = "SettingsForm";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPhonePort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPCPort;
    }
}