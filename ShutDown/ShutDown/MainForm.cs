using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDown
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            decimal time = numericUpDownHour.Value * 3600 + numericUpDownMinute.Value * 60 + numericUpDownSecond.Value;
            if (time == 0)
            {
                if (MessageBox.Show("要立即关机吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    System.Diagnostics.Process.Start(@"C:\Windows\System32\shutdown.exe","-s -t " + time.ToString());
            }
            else
                System.Diagnostics.Process.Start(@"C:\Windows\System32\shutdown.exe", "-s -t " + time.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\shutdown.exe", "-a");
        }
    }
}
