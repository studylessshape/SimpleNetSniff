namespace NetSniff
{
    partial class SniffWindow
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
            this.splitPacketListAndOther = new System.Windows.Forms.SplitContainer();
            this.listViewPacket = new System.Windows.Forms.ListView();
            this.columnHeaderIndex = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSourceIP = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDestination = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPacketType = new System.Windows.Forms.ColumnHeader();
            this.splitTreeViewAndOther = new System.Windows.Forms.SplitContainer();
            this.treeViewDesequencePacket = new System.Windows.Forms.TreeView();
            this.splitRawDataAndOther = new System.Windows.Forms.SplitContainer();
            this.splitContainerRawData = new System.Windows.Forms.SplitContainer();
            this.textBoxRawData = new System.Windows.Forms.TextBox();
            this.textBoxConvertRawData = new System.Windows.Forms.TextBox();
            this.splitStatisticsAndFilter = new System.Windows.Forms.SplitContainer();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.textBoxStatistcs = new System.Windows.Forms.TextBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.splitFilterContentAndButton = new System.Windows.Forms.SplitContainer();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.splitButtonPos = new System.Windows.Forms.SplitContainer();
            this.sniffStateChangeButton = new System.Windows.Forms.Button();
            this.enableFilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitPacketListAndOther)).BeginInit();
            this.splitPacketListAndOther.Panel1.SuspendLayout();
            this.splitPacketListAndOther.Panel2.SuspendLayout();
            this.splitPacketListAndOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTreeViewAndOther)).BeginInit();
            this.splitTreeViewAndOther.Panel1.SuspendLayout();
            this.splitTreeViewAndOther.Panel2.SuspendLayout();
            this.splitTreeViewAndOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRawDataAndOther)).BeginInit();
            this.splitRawDataAndOther.Panel1.SuspendLayout();
            this.splitRawDataAndOther.Panel2.SuspendLayout();
            this.splitRawDataAndOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawData)).BeginInit();
            this.splitContainerRawData.Panel1.SuspendLayout();
            this.splitContainerRawData.Panel2.SuspendLayout();
            this.splitContainerRawData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitStatisticsAndFilter)).BeginInit();
            this.splitStatisticsAndFilter.Panel1.SuspendLayout();
            this.splitStatisticsAndFilter.Panel2.SuspendLayout();
            this.splitStatisticsAndFilter.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitFilterContentAndButton)).BeginInit();
            this.splitFilterContentAndButton.Panel1.SuspendLayout();
            this.splitFilterContentAndButton.Panel2.SuspendLayout();
            this.splitFilterContentAndButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitButtonPos)).BeginInit();
            this.splitButtonPos.Panel1.SuspendLayout();
            this.splitButtonPos.Panel2.SuspendLayout();
            this.splitButtonPos.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitPacketListAndOther
            // 
            this.splitPacketListAndOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPacketListAndOther.Location = new System.Drawing.Point(0, 0);
            this.splitPacketListAndOther.Name = "splitPacketListAndOther";
            this.splitPacketListAndOther.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPacketListAndOther.Panel1
            // 
            this.splitPacketListAndOther.Panel1.Controls.Add(this.listViewPacket);
            this.splitPacketListAndOther.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // splitPacketListAndOther.Panel2
            // 
            this.splitPacketListAndOther.Panel2.Controls.Add(this.splitTreeViewAndOther);
            this.splitPacketListAndOther.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitPacketListAndOther.Size = new System.Drawing.Size(839, 492);
            this.splitPacketListAndOther.SplitterDistance = 156;
            this.splitPacketListAndOther.TabIndex = 1;
            // 
            // listViewPacket
            // 
            this.listViewPacket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIndex,
            this.columnHeaderSourceIP,
            this.columnHeaderDestination,
            this.columnHeaderPacketType});
            this.listViewPacket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPacket.FullRowSelect = true;
            this.listViewPacket.GridLines = true;
            this.listViewPacket.HideSelection = false;
            this.listViewPacket.Location = new System.Drawing.Point(6, 6);
            this.listViewPacket.Name = "listViewPacket";
            this.listViewPacket.Size = new System.Drawing.Size(827, 144);
            this.listViewPacket.TabIndex = 0;
            this.listViewPacket.UseCompatibleStateImageBehavior = false;
            this.listViewPacket.View = System.Windows.Forms.View.Details;
            this.listViewPacket.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewPacket_ItemSelectionChanged);
            // 
            // columnHeaderIndex
            // 
            this.columnHeaderIndex.Text = "编号";
            // 
            // columnHeaderSourceIP
            // 
            this.columnHeaderSourceIP.Text = "源IP地址";
            this.columnHeaderSourceIP.Width = 120;
            // 
            // columnHeaderDestination
            // 
            this.columnHeaderDestination.Text = "目的IP地址";
            this.columnHeaderDestination.Width = 120;
            // 
            // columnHeaderPacketType
            // 
            this.columnHeaderPacketType.Text = "协议类型";
            this.columnHeaderPacketType.Width = 80;
            // 
            // splitTreeViewAndOther
            // 
            this.splitTreeViewAndOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTreeViewAndOther.Location = new System.Drawing.Point(5, 5);
            this.splitTreeViewAndOther.Name = "splitTreeViewAndOther";
            // 
            // splitTreeViewAndOther.Panel1
            // 
            this.splitTreeViewAndOther.Panel1.Controls.Add(this.treeViewDesequencePacket);
            // 
            // splitTreeViewAndOther.Panel2
            // 
            this.splitTreeViewAndOther.Panel2.Controls.Add(this.splitRawDataAndOther);
            this.splitTreeViewAndOther.Panel2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.splitTreeViewAndOther.Size = new System.Drawing.Size(829, 322);
            this.splitTreeViewAndOther.SplitterDistance = 331;
            this.splitTreeViewAndOther.TabIndex = 0;
            // 
            // treeViewDesequencePacket
            // 
            this.treeViewDesequencePacket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDesequencePacket.Location = new System.Drawing.Point(0, 0);
            this.treeViewDesequencePacket.Name = "treeViewDesequencePacket";
            this.treeViewDesequencePacket.Size = new System.Drawing.Size(331, 322);
            this.treeViewDesequencePacket.TabIndex = 0;
            // 
            // splitRawDataAndOther
            // 
            this.splitRawDataAndOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRawDataAndOther.Location = new System.Drawing.Point(5, 0);
            this.splitRawDataAndOther.Name = "splitRawDataAndOther";
            this.splitRawDataAndOther.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRawDataAndOther.Panel1
            // 
            this.splitRawDataAndOther.Panel1.Controls.Add(this.splitContainerRawData);
            // 
            // splitRawDataAndOther.Panel2
            // 
            this.splitRawDataAndOther.Panel2.Controls.Add(this.splitStatisticsAndFilter);
            this.splitRawDataAndOther.Size = new System.Drawing.Size(484, 322);
            this.splitRawDataAndOther.SplitterDistance = 150;
            this.splitRawDataAndOther.TabIndex = 0;
            // 
            // splitContainerRawData
            // 
            this.splitContainerRawData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRawData.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRawData.Name = "splitContainerRawData";
            // 
            // splitContainerRawData.Panel1
            // 
            this.splitContainerRawData.Panel1.Controls.Add(this.textBoxRawData);
            // 
            // splitContainerRawData.Panel2
            // 
            this.splitContainerRawData.Panel2.Controls.Add(this.textBoxConvertRawData);
            this.splitContainerRawData.Size = new System.Drawing.Size(484, 150);
            this.splitContainerRawData.SplitterDistance = 244;
            this.splitContainerRawData.TabIndex = 0;
            // 
            // textBoxRawData
            // 
            this.textBoxRawData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRawData.Location = new System.Drawing.Point(0, 0);
            this.textBoxRawData.Multiline = true;
            this.textBoxRawData.Name = "textBoxRawData";
            this.textBoxRawData.ReadOnly = true;
            this.textBoxRawData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRawData.Size = new System.Drawing.Size(244, 150);
            this.textBoxRawData.TabIndex = 0;
            // 
            // textBoxConvertRawData
            // 
            this.textBoxConvertRawData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxConvertRawData.Location = new System.Drawing.Point(0, 0);
            this.textBoxConvertRawData.Multiline = true;
            this.textBoxConvertRawData.Name = "textBoxConvertRawData";
            this.textBoxConvertRawData.ReadOnly = true;
            this.textBoxConvertRawData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConvertRawData.Size = new System.Drawing.Size(236, 150);
            this.textBoxConvertRawData.TabIndex = 0;
            // 
            // splitStatisticsAndFilter
            // 
            this.splitStatisticsAndFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitStatisticsAndFilter.Location = new System.Drawing.Point(0, 0);
            this.splitStatisticsAndFilter.Name = "splitStatisticsAndFilter";
            // 
            // splitStatisticsAndFilter.Panel1
            // 
            this.splitStatisticsAndFilter.Panel1.Controls.Add(this.groupBoxStatistics);
            // 
            // splitStatisticsAndFilter.Panel2
            // 
            this.splitStatisticsAndFilter.Panel2.Controls.Add(this.groupBoxFilter);
            this.splitStatisticsAndFilter.Size = new System.Drawing.Size(484, 168);
            this.splitStatisticsAndFilter.SplitterDistance = 229;
            this.splitStatisticsAndFilter.TabIndex = 0;
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.textBoxStatistcs);
            this.groupBoxStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStatistics.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(229, 168);
            this.groupBoxStatistics.TabIndex = 0;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "统计";
            // 
            // textBoxStatistcs
            // 
            this.textBoxStatistcs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStatistcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStatistcs.Location = new System.Drawing.Point(3, 23);
            this.textBoxStatistcs.Multiline = true;
            this.textBoxStatistcs.Name = "textBoxStatistcs";
            this.textBoxStatistcs.ReadOnly = true;
            this.textBoxStatistcs.Size = new System.Drawing.Size(223, 142);
            this.textBoxStatistcs.TabIndex = 0;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.splitFilterContentAndButton);
            this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilter.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(251, 168);
            this.groupBoxFilter.TabIndex = 0;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "过滤规则";
            // 
            // splitFilterContentAndButton
            // 
            this.splitFilterContentAndButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitFilterContentAndButton.IsSplitterFixed = true;
            this.splitFilterContentAndButton.Location = new System.Drawing.Point(3, 23);
            this.splitFilterContentAndButton.Name = "splitFilterContentAndButton";
            this.splitFilterContentAndButton.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitFilterContentAndButton.Panel1
            // 
            this.splitFilterContentAndButton.Panel1.Controls.Add(this.textBoxFilter);
            // 
            // splitFilterContentAndButton.Panel2
            // 
            this.splitFilterContentAndButton.Panel2.Controls.Add(this.splitButtonPos);
            this.splitFilterContentAndButton.Size = new System.Drawing.Size(245, 142);
            this.splitFilterContentAndButton.SplitterDistance = 98;
            this.splitFilterContentAndButton.TabIndex = 0;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFilter.Location = new System.Drawing.Point(0, 0);
            this.textBoxFilter.Multiline = true;
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(245, 98);
            this.textBoxFilter.TabIndex = 1;
            // 
            // splitButtonPos
            // 
            this.splitButtonPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitButtonPos.Location = new System.Drawing.Point(0, 0);
            this.splitButtonPos.Name = "splitButtonPos";
            // 
            // splitButtonPos.Panel1
            // 
            this.splitButtonPos.Panel1.Controls.Add(this.sniffStateChangeButton);
            // 
            // splitButtonPos.Panel2
            // 
            this.splitButtonPos.Panel2.Controls.Add(this.enableFilterButton);
            this.splitButtonPos.Size = new System.Drawing.Size(245, 40);
            this.splitButtonPos.SplitterDistance = 118;
            this.splitButtonPos.TabIndex = 0;
            // 
            // sniffStateChangeButton
            // 
            this.sniffStateChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sniffStateChangeButton.Location = new System.Drawing.Point(0, 0);
            this.sniffStateChangeButton.Name = "sniffStateChangeButton";
            this.sniffStateChangeButton.Size = new System.Drawing.Size(118, 40);
            this.sniffStateChangeButton.TabIndex = 0;
            this.sniffStateChangeButton.Text = "暂停嗅探";
            this.sniffStateChangeButton.UseVisualStyleBackColor = true;
            this.sniffStateChangeButton.Click += new System.EventHandler(this.sniffStateChangeButton_Click);
            // 
            // enableFilterButton
            // 
            this.enableFilterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enableFilterButton.Location = new System.Drawing.Point(0, 0);
            this.enableFilterButton.Name = "enableFilterButton";
            this.enableFilterButton.Size = new System.Drawing.Size(123, 40);
            this.enableFilterButton.TabIndex = 0;
            this.enableFilterButton.Text = "启用规则";
            this.enableFilterButton.UseVisualStyleBackColor = true;
            this.enableFilterButton.Click += new System.EventHandler(this.enableFilterButton_Click);
            // 
            // SniffWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 492);
            this.Controls.Add(this.splitPacketListAndOther);
            this.Name = "SniffWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SniffWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SniffWindow_FormClosing);
            this.Load += new System.EventHandler(this.SniffWindow_Load);
            this.splitPacketListAndOther.Panel1.ResumeLayout(false);
            this.splitPacketListAndOther.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPacketListAndOther)).EndInit();
            this.splitPacketListAndOther.ResumeLayout(false);
            this.splitTreeViewAndOther.Panel1.ResumeLayout(false);
            this.splitTreeViewAndOther.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTreeViewAndOther)).EndInit();
            this.splitTreeViewAndOther.ResumeLayout(false);
            this.splitRawDataAndOther.Panel1.ResumeLayout(false);
            this.splitRawDataAndOther.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRawDataAndOther)).EndInit();
            this.splitRawDataAndOther.ResumeLayout(false);
            this.splitContainerRawData.Panel1.ResumeLayout(false);
            this.splitContainerRawData.Panel1.PerformLayout();
            this.splitContainerRawData.Panel2.ResumeLayout(false);
            this.splitContainerRawData.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawData)).EndInit();
            this.splitContainerRawData.ResumeLayout(false);
            this.splitStatisticsAndFilter.Panel1.ResumeLayout(false);
            this.splitStatisticsAndFilter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitStatisticsAndFilter)).EndInit();
            this.splitStatisticsAndFilter.ResumeLayout(false);
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.splitFilterContentAndButton.Panel1.ResumeLayout(false);
            this.splitFilterContentAndButton.Panel1.PerformLayout();
            this.splitFilterContentAndButton.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitFilterContentAndButton)).EndInit();
            this.splitFilterContentAndButton.ResumeLayout(false);
            this.splitButtonPos.Panel1.ResumeLayout(false);
            this.splitButtonPos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitButtonPos)).EndInit();
            this.splitButtonPos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitPacketListAndOther;
        private System.Windows.Forms.SplitContainer splitTreeViewAndOther;
        private System.Windows.Forms.ListView listViewPacket;
        private System.Windows.Forms.TreeView treeViewDesequencePacket;
        private System.Windows.Forms.SplitContainer splitRawDataAndOther;
        private System.Windows.Forms.SplitContainer splitStatisticsAndFilter;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.SplitContainer splitFilterContentAndButton;
        private System.Windows.Forms.SplitContainer splitButtonPos;
        private System.Windows.Forms.Button enableFilterButton;
        private System.Windows.Forms.ColumnHeader columnHeaderIndex;
        private System.Windows.Forms.ColumnHeader columnHeaderSourceIP;
        private System.Windows.Forms.ColumnHeader columnHeaderDestination;
        private System.Windows.Forms.ColumnHeader columnHeaderPacketType;
        private System.Windows.Forms.Button sniffStateChangeButton;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.TextBox textBoxRawData;
        private System.Windows.Forms.SplitContainer splitContainerRawData;
        private System.Windows.Forms.TextBox textBoxConvertRawData;
        private System.Windows.Forms.TextBox textBoxStatistcs;
    }
}