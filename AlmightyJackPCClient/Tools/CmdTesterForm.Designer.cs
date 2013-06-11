namespace AlmightyJackPCClient.Tools
{
    partial class CmdTesterForm
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
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCmd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(272, 377);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "命令ID：";
            // 
            // txbCmd
            // 
            this.txbCmd.Location = new System.Drawing.Point(96, 40);
            this.txbCmd.Name = "txbCmd";
            this.txbCmd.Size = new System.Drawing.Size(100, 21);
            this.txbCmd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "测试结果：";
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(96, 76);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(488, 277);
            this.txbResult.TabIndex = 2;
            // 
            // CmdTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 423);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCmd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Name = "CmdTesterForm";
            this.Text = "CmdTesterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbResult;
    }
}