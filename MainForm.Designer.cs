namespace NetSniff
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promiscuousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.readTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceInfomationTextBox = new System.Windows.Forms.TextBox();
            this.deviceChoiceBox = new System.Windows.Forms.ComboBox();
            this.deviceChoiceLabel = new System.Windows.Forms.Label();
            this.startSniffButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模式ToolStripMenuItem,
            this.refreshRToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 模式ToolStripMenuItem
            // 
            this.模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.promiscuousToolStripMenuItem,
            this.toolStripSeparator1,
            this.readTimeoutToolStripMenuItem});
            this.模式ToolStripMenuItem.Name = "模式ToolStripMenuItem";
            this.模式ToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.模式ToolStripMenuItem.Text = "模式(&M)";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.normalToolStripMenuItem.Text = "普通模式(&N)";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.普通模式ToolStripMenuItem_Click);
            // 
            // promiscuousToolStripMenuItem
            // 
            this.promiscuousToolStripMenuItem.Name = "promiscuousToolStripMenuItem";
            this.promiscuousToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.promiscuousToolStripMenuItem.Text = "混杂模式(&P)";
            this.promiscuousToolStripMenuItem.Click += new System.EventHandler(this.混杂模式ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // readTimeoutToolStripMenuItem
            // 
            this.readTimeoutToolStripMenuItem.Name = "readTimeoutToolStripMenuItem";
            this.readTimeoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.readTimeoutToolStripMenuItem.Text = "超时时间设置(&T)";
            this.readTimeoutToolStripMenuItem.Click += new System.EventHandler(this.readTimeoutToolStripMenuItem_Click);
            // 
            // refreshRToolStripMenuItem
            // 
            this.refreshRToolStripMenuItem.Name = "refreshRToolStripMenuItem";
            this.refreshRToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.refreshRToolStripMenuItem.Text = "刷新(&R)";
            this.refreshRToolStripMenuItem.Click += new System.EventHandler(this.刷新RToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.aboutToolStripMenuItem.Text = "关于(&A)";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // deviceInfomationTextBox
            // 
            this.deviceInfomationTextBox.Location = new System.Drawing.Point(12, 75);
            this.deviceInfomationTextBox.Multiline = true;
            this.deviceInfomationTextBox.Name = "deviceInfomationTextBox";
            this.deviceInfomationTextBox.ReadOnly = true;
            this.deviceInfomationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deviceInfomationTextBox.Size = new System.Drawing.Size(717, 183);
            this.deviceInfomationTextBox.TabIndex = 3;
            this.deviceInfomationTextBox.TabStop = false;
            // 
            // deviceChoiceBox
            // 
            this.deviceChoiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceChoiceBox.FormattingEnabled = true;
            this.deviceChoiceBox.Location = new System.Drawing.Point(87, 41);
            this.deviceChoiceBox.Name = "deviceChoiceBox";
            this.deviceChoiceBox.Size = new System.Drawing.Size(642, 28);
            this.deviceChoiceBox.TabIndex = 2;
            this.deviceChoiceBox.SelectedIndexChanged += new System.EventHandler(this.deviceChoiceBox_SelectedIndexChanged);
            // 
            // deviceChoiceLabel
            // 
            this.deviceChoiceLabel.AutoSize = true;
            this.deviceChoiceLabel.Location = new System.Drawing.Point(12, 44);
            this.deviceChoiceLabel.Name = "deviceChoiceLabel";
            this.deviceChoiceLabel.Size = new System.Drawing.Size(69, 20);
            this.deviceChoiceLabel.TabIndex = 1;
            this.deviceChoiceLabel.Text = "网卡选择";
            // 
            // startSniffButton
            // 
            this.startSniffButton.Location = new System.Drawing.Point(289, 264);
            this.startSniffButton.Name = "startSniffButton";
            this.startSniffButton.Size = new System.Drawing.Size(125, 56);
            this.startSniffButton.TabIndex = 4;
            this.startSniffButton.Text = "开始嗅探";
            this.startSniffButton.UseVisualStyleBackColor = true;
            this.startSniffButton.Click += new System.EventHandler(this.startSniffButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 332);
            this.Controls.Add(this.startSniffButton);
            this.Controls.Add(this.deviceInfomationTextBox);
            this.Controls.Add(this.deviceChoiceBox);
            this.Controls.Add(this.deviceChoiceLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "嗅探器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox deviceInfomationTextBox;
        private System.Windows.Forms.ComboBox deviceChoiceBox;
        private System.Windows.Forms.Label deviceChoiceLabel;
        private System.Windows.Forms.Button startSniffButton;
        private System.Windows.Forms.ToolStripMenuItem refreshRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promiscuousToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem readTimeoutToolStripMenuItem;
    }
}
