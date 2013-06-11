namespace AlmightyJackPCClient
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStartFWD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCommandTester = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemStartFWD,
            this.toolStripMenuItem2,
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(58, 21);
            this.ToolStripMenuItemFile.Text = "文件(&F)";
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(168, 22);
            this.ToolStripMenuItemExit.Text = "退出(&X)";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ToolStripMenuItemStartFWD
            // 
            this.ToolStripMenuItemStartFWD.Name = "ToolStripMenuItemStartFWD";
            this.ToolStripMenuItemStartFWD.Size = new System.Drawing.Size(168, 22);
            this.ToolStripMenuItemStartFWD.Text = "开启端口转发(&W)";
            this.ToolStripMenuItemStartFWD.Click += new System.EventHandler(this.ToolStripMenuItemStartFWD_Click);
            // 
            // ToolStripMenuItemTools
            // 
            this.ToolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCommandTester,
            this.toolStripMenuItem1,
            this.ToolStripMenuItemSetting});
            this.ToolStripMenuItemTools.Name = "ToolStripMenuItemTools";
            this.ToolStripMenuItemTools.Size = new System.Drawing.Size(59, 21);
            this.ToolStripMenuItemTools.Text = "工具(&T)";
            // 
            // ToolStripMenuItemCommandTester
            // 
            this.ToolStripMenuItemCommandTester.Name = "ToolStripMenuItemCommandTester";
            this.ToolStripMenuItemCommandTester.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemCommandTester.Text = "命令测试器(&C)";
            this.ToolStripMenuItemCommandTester.Click += new System.EventHandler(this.ToolStripMenuItemCommandTester_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // ToolStripMenuItemSetting
            // 
            this.ToolStripMenuItemSetting.Name = "ToolStripMenuItemSetting";
            this.ToolStripMenuItemSetting.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemSetting.Text = "设置(&S)";
            this.ToolStripMenuItemSetting.Click += new System.EventHandler(this.ToolStripMenuItemSetting_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 227);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "AlmightyJackPCClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCommandTester;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStartFWD;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

