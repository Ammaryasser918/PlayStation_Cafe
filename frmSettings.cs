using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameZonePlaystationCafe_Desktop
{



    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        public Form MainMenu { get; set; }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            btnApply.Visible = false;
            btnCancel.Visible = false;
            textBox1.Text = clsGlobalSettings.HourlyRate.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OldPrice = clsGlobalSettings.HourlyRate;
            textBox1.ReadOnly = false;
            btnApply.Visible = true;
            btnCancel.Visible = true;
        }
        double OldPrice = clsGlobalSettings.HourlyRate;
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double rate))
            {
                clsGlobalSettings.HourlyRate = rate;
                MessageBox.Show("New Price Saved Successfully", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnApply.Visible = false;
                btnCancel.Visible = false;
            }
            else
            {
                MessageBox.Show("Hourly Rate Should Be Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (MainMenu != null)
            {
                MainMenu.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnApply.Visible = false;
            clsGlobalSettings.HourlyRate = OldPrice;
            btnCancel.Visible = false;
            textBox1.ReadOnly = true;
        }
    }
}
