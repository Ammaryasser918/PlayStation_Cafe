namespace GameZonePlaystationCafe_Desktop
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 56);
            label1.Name = "label1";
            label1.Size = new Size(354, 74);
            label1.TabIndex = 0;
            label1.Text = "Game Zone";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Rockwell", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(382, 388);
            button1.Name = "button1";
            button1.Size = new Size(340, 73);
            button1.TabIndex = 1;
            button1.Text = "ROOMS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Rockwell", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(382, 506);
            button2.Name = "button2";
            button2.Size = new Size(340, 73);
            button2.TabIndex = 1;
            button2.Text = "SETTINGS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1123, 789);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "frmMainScreen";
            Text = "frmMainScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}