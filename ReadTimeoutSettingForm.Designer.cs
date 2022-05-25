namespace NetSniff
{
    partial class ReadTimeoutSettingForm
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
            this.numericUpDownReadTimeout = new System.Windows.Forms.NumericUpDown();
            this.buttonConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReadTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownReadTimeout
            // 
            this.numericUpDownReadTimeout.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownReadTimeout.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDownReadTimeout.Name = "numericUpDownReadTimeout";
            this.numericUpDownReadTimeout.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownReadTimeout.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(42, 45);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(94, 29);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "确认";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // ReadTimeoutSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 88);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.numericUpDownReadTimeout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReadTimeoutSettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "超时时间设置";
            this.Load += new System.EventHandler(this.ReadTimeoutSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReadTimeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownReadTimeout;
        private System.Windows.Forms.Button buttonConfirm;
    }
}