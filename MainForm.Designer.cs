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
            this.刷新RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.刷新RToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 刷新RToolStripMenuItem
            // 
            this.刷新RToolStripMenuItem.Name = "刷新RToolStripMenuItem";
            this.刷新RToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.刷新RToolStripMenuItem.Text = "刷新(&R)";
            this.刷新RToolStripMenuItem.Click += new System.EventHandler(this.刷新RToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TextBox deviceInfomationTextBox;
        private System.Windows.Forms.ComboBox deviceChoiceBox;
        private System.Windows.Forms.Label deviceChoiceLabel;
        private System.Windows.Forms.Button startSniffButton;
        private System.Windows.Forms.ToolStripMenuItem 刷新RToolStripMenuItem;
    }
}
