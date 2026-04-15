using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameZonePlaystationCafe_Desktop
{



    public partial class ctrlGameItem : UserControl
    {
        private string _roomtitle = "Room Title";
        private double _hourlyrate = -1;
        [Category("Playstation Settings")]
        [Description("Sets the name or number of playstation Room/Device")]
        public double Hourly_Rate
        {
            get
            {
                return _hourlyrate;
            }
            set
            {
                _hourlyrate = value;
            }
        }
        public string RoomTitle
        {
            get
            {
                return _roomtitle;
            }
            set
            {
                _roomtitle = value;

                if (lblRoomTitle != null)
                {
                    lblRoomTitle.Text = value;
                }
            }
        }


        public class SessionEventArgs : EventArgs
        {
            public double HourlyRate { get; set; }
            public TimeSpan TimeConsumed { get; set; }
            public double TotalCost { get; set; }
            public SessionEventArgs(double rate, string timeConsumed)
            {
                HourlyRate = rate;
                TimeConsumed = TimeSpan.Parse(timeConsumed);
                TotalCost = (double)HourlyRate * (double)TimeConsumed.TotalHours;
            }
        }


        [Category("Room Settings")]
        [Description("Handles actions on the Rooms/Devices")]
        public event EventHandler<SessionEventArgs> SessionEnded;

        Stopwatch stopwatch;

        public void UpdateRoomTitle(string NewTitle)
        {
            this.RoomTitle = NewTitle;
        }

        public ctrlGameItem()
        {
            InitializeComponent();
        }

        private void ctrlGameItem_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }


        private void btnEnd_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            timer1.Stop();
            btnStart.Text = "Start";
            btnStart.BackColor = Color.Turquoise;

            OnSessionEnded(new SessionEventArgs(clsGlobalSettings.HourlyRate, lblTimer.Text));

            lblTimer.Text = "00:00:00";

        }

        public virtual void OnSessionEnded(SessionEventArgs e)
        {
            SessionEnded?.Invoke(this, e);
        }


        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                stopwatch.Start();
                btnStart.Text = "Pause";
                btnStart.BackColor = Color.LightGreen;
                timer1.Start();
            }
            else if (btnStart.Text == "Pause")
            {
                stopwatch.Stop();
                btnStart.Text = "Continue";
                btnStart.BackColor = Color.Orange;
                timer1.Stop();
            }
            else
            {
                stopwatch.Start();
                btnStart.Text = "Pause";
                btnStart.BackColor = Color.LightGreen;
                timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.MediumTurquoise;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Turquoise;
        }

        private void btnEnd_MouseEnter(object sender, EventArgs e)
        {
            btnEnd.BackColor = Color.MediumTurquoise;
        }

        private void btnEnd_MouseLeave(object sender, EventArgs e)
        {
            btnEnd.BackColor = Color.Turquoise;
        }

        private void gbRoom_Enter(object sender, EventArgs e)
        {

        }
    }
}
