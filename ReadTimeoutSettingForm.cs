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
    public partial class ReadTimeoutSettingForm : Form
    {
        private NetSniffHelper sniffHelper;

        public ReadTimeoutSettingForm(NetSniffHelper sniffHelper)
        {
            InitializeComponent();

            this.sniffHelper = sniffHelper;
        }

        private void ReadTimeoutSettingForm_Load(object sender, EventArgs e)
        {
            numericUpDownReadTimeout.Value = sniffHelper.ReadTimeout;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            sniffHelper.ReadTimeout = (int)numericUpDownReadTimeout.Value;
            this.Close();
        }
    }
}
