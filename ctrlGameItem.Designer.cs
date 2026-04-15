namespace GameZonePlaystationCafe_Desktop
{
    partial class ctrlGameItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlGameItem));
            gbRoom = new GroupBox();
            btnEnd = new Button();
            btnStart = new Button();
            lblRoomTitle = new Label();
            lblTimer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            gbRoom.SuspendLayout();
            SuspendLayout();
            // 
            // gbRoom
            // 
            gbRoom.BackColor = Color.Transparent;
            gbRoom.Controls.Add(btnEnd);
            gbRoom.Controls.Add(btnStart);
            gbRoom.Controls.Add(lblRoomTitle);
            gbRoom.Controls.Add(lblTimer);
            gbRoom.Location = new Point(3, -6);
            gbRoom.Name = "gbRoom";
            gbRoom.Size = new Size(344, 275);
            gbRoom.TabIndex = 0;
            gbRoom.TabStop = false;
            gbRoom.Enter += gbRoom_Enter;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Turquoise;
            btnEnd.Location = new Point(24, 130);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(109, 44);
            btnEnd.TabIndex = 1;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Turquoise;
            btnStart.Location = new Point(207, 130);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(109, 44);
            btnStart.TabIndex = 1;
            btnStart.Tag = "";
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStartPause_Click;
            // 
            // lblRoomTitle
            // 
            lblRoomTitle.AutoSize = true;
            lblRoomTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomTitle.Location = new Point(124, 41);
            lblRoomTitle.Name = "lblRoomTitle";
            lblRoomTitle.Size = new Size(120, 31);
            lblRoomTitle.TabIndex = 0;
            lblRoomTitle.Text = "RoomTitle";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(110, 210);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(134, 41);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ctrlGameItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(gbRoom);
            Name = "ctrlGameItem";
            Size = new Size(353, 275);
            Load += ctrlGameItem_Load;
            gbRoom.ResumeLayout(false);
            gbRoom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbRoom;
        private Button btnStart;
        private Label lblTimer;
        private Button btnEnd;
        private Label lblRoomTitle;
        private System.Windows.Forms.Timer timer1;
    }
}
