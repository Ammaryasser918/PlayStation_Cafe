namespace GameZonePlaystationCafe_Desktop
{
    public partial class frmRoomControl : Form
    {
        public frmRoomControl()
        {
            InitializeComponent();
        }

        public Form MainMenu { get; set; }

        private void ctrlGameItem1_SessionEnded(ctrlGameItem sender, GameZonePlaystationCafe_Desktop.ctrlGameItem.SessionEventArgs e)
        {
            MessageBox.Show($"Session Ended in room {sender.RoomTitle}:\nHourly Rate : {e.HourlyRate}\nTime Consumed : {e.TimeConsumed}\nTotal Cost : {e.TotalCost}",
                             "Note", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void ShowSessionEndedMessage(object sender, GameZonePlaystationCafe_Desktop.ctrlGameItem.SessionEventArgs e)
        {
            ctrlGameItem item = sender as ctrlGameItem;

            if (item != null)
            {
                MessageBox.Show($"Session Ended in room {item.RoomTitle}:\nHourly Rate : {e.HourlyRate}\nTime Consumed : {e.TimeConsumed}\nTotal Cost : {e.TotalCost}",
                             "Note", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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

        private void frmRoomControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();

                if (MainMenu != null)
                {
                    MainMenu.Show();
                }
            }
        }
    }
}
