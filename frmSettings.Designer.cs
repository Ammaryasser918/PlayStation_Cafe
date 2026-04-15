namespace GameZonePlaystationCafe_Desktop
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            btnBackToMain = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            btnApply = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnBackToMain
            // 
            btnBackToMain.BackgroundImage = (Image)resources.GetObject("btnBackToMain.BackgroundImage");
            btnBackToMain.BackgroundImageLayout = ImageLayout.Stretch;
            btnBackToMain.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackToMain.Location = new Point(835, 12);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(60, 60);
            btnBackToMain.TabIndex = 2;
            btnBackToMain.UseVisualStyleBackColor = true;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 163);
            label1.Name = "label1";
            label1.Size = new Size(228, 46);
            label1.TabIndex = 3;
            label1.Text = "Hourly Rate : ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(278, 180);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(218, 34);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(533, 177);
            button1.Name = "button1";
            button1.Size = new Size(119, 37);
            button1.TabIndex = 5;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnApply
            // 
            btnApply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApply.Location = new Point(533, 230);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(119, 37);
            btnApply.TabIndex = 5;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(533, 281);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 37);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(918, 550);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnBackToMain);
            Name = "frmSettings";
            Text = "frmSettings";
            Load += frmSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackToMain;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button btnApply;
        private Button btnCancel;
    }
}