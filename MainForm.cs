using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSniff
{
    public partial class MainForm : Form
    {
        private NetSniffHelper sniffHelper = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DeviceInitial();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AboutInfomation.SequenceString(), "关于");
        }

        private void deviceChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 将网卡信息显示到文本框
            string info =
                sniffHelper.Devices[deviceChoiceBox.SelectedIndex].ToString();
            deviceInfomationTextBox.Text = info.Replace("\n", Environment.NewLine);
            if (!startSniffButton.Enabled)
                startSniffButton.Enabled = true;
        }

        private void startSniffButton_Click(object sender, EventArgs e)
        {
            SniffWindow sniffWindow = new SniffWindow(sniffHelper.Devices[deviceChoiceBox.SelectedIndex], sniffHelper);
            //sniffWindow.ShowDialog();
            sniffWindow.ShowInTaskbar = true;
            sniffWindow.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 刷新RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceInitial();
        }

        private void DeviceInitial()
        {
            startSniffButton.Enabled = false;
            deviceInfomationTextBox.Text = "";
            deviceChoiceBox.Items.Clear();
            sniffHelper = new NetSniffHelper();

            if (sniffHelper.Devices == null || sniffHelper.Devices.Count <= 0)
            {
                MessageBox.Show("查找网卡失败！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int len = sniffHelper.Devices.Count;
                for (int i = 0; i < len; i++)
                {
                    deviceChoiceBox.Items.Add($"{sniffHelper.Devices[i].Description} : {sniffHelper.Devices[i].Name}");
                }

                normalToolStripMenuItem.Checked = true;
                promiscuousToolStripMenuItem.Checked = false;
            }
        }

        private void 普通模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sniffHelper.Mode = SharpPcap.DeviceMode.Normal;

            normalToolStripMenuItem.Checked = true;
            promiscuousToolStripMenuItem.Checked = false;
        }

        private void 混杂模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sniffHelper.Mode = SharpPcap.DeviceMode.Promiscuous;

            normalToolStripMenuItem.Checked = false;
            promiscuousToolStripMenuItem.Checked = true;
        }

        private void readTimeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadTimeoutSettingForm readTimeoutSettingForm = new ReadTimeoutSettingForm(sniffHelper);
            readTimeoutSettingForm.ShowDialog();
        }
    }
}
