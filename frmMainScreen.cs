using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameZonePlaystationCafe_Desktop
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        frmRoomControl frmRooms = null;
        frmSettings settings = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (frmRooms == null || frmRooms.IsDisposed)
            {
                frmRooms = new frmRoomControl();
                frmRooms.FormClosed += (s, args) => this.Close();
                frmRooms.MainMenu = this;
            }


            frmRooms.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (settings == null || settings.IsDisposed)
            {
                settings = new frmSettings();
                settings.FormClosed += (s, args) => this.Close();
                settings.MainMenu = this;
            }

            settings.Show();
            this.Hide();

        }
    }
}
