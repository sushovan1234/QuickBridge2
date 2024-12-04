namespace QuickBridge.UI
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            LogDetailsBtn = new Button();
            SyncedDatasBtn = new Button();
            SettingBtn = new Button();
            FleetPandDashBoardBtn = new Button();
            QuickBridgeDashboardbtn = new Button();
            panel2 = new Panel();
            Usernamelbl = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(LogDetailsBtn);
            panel1.Controls.Add(SyncedDatasBtn);
            panel1.Controls.Add(SettingBtn);
            panel1.Controls.Add(FleetPandDashBoardBtn);
            panel1.Controls.Add(QuickBridgeDashboardbtn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 393);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(0, 330);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(250, 38);
            button1.TabIndex = 8;
            button1.Text = "Sign Out";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(0, 290);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(250, 40);
            button2.TabIndex = 7;
            button2.Text = "User Management";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // LogDetailsBtn
            // 
            LogDetailsBtn.Dock = DockStyle.Top;
            LogDetailsBtn.FlatAppearance.BorderSize = 0;
            LogDetailsBtn.FlatStyle = FlatStyle.Flat;
            LogDetailsBtn.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogDetailsBtn.ForeColor = SystemColors.ActiveCaptionText;
            LogDetailsBtn.Image = (Image)resources.GetObject("LogDetailsBtn.Image");
            LogDetailsBtn.ImageAlign = ContentAlignment.TopLeft;
            LogDetailsBtn.Location = new Point(0, 250);
            LogDetailsBtn.Name = "LogDetailsBtn";
            LogDetailsBtn.RightToLeft = RightToLeft.Yes;
            LogDetailsBtn.Size = new Size(250, 40);
            LogDetailsBtn.TabIndex = 6;
            LogDetailsBtn.Text = "Log Details";
            LogDetailsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // SyncedDatasBtn
            // 
            SyncedDatasBtn.Dock = DockStyle.Top;
            SyncedDatasBtn.FlatAppearance.BorderSize = 0;
            SyncedDatasBtn.FlatStyle = FlatStyle.Flat;
            SyncedDatasBtn.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SyncedDatasBtn.ForeColor = SystemColors.ActiveCaptionText;
            SyncedDatasBtn.Image = (Image)resources.GetObject("SyncedDatasBtn.Image");
            SyncedDatasBtn.ImageAlign = ContentAlignment.TopLeft;
            SyncedDatasBtn.Location = new Point(0, 210);
            SyncedDatasBtn.Name = "SyncedDatasBtn";
            SyncedDatasBtn.RightToLeft = RightToLeft.Yes;
            SyncedDatasBtn.Size = new Size(250, 40);
            SyncedDatasBtn.TabIndex = 5;
            SyncedDatasBtn.Text = "Synced Datas";
            SyncedDatasBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SyncedDatasBtn.UseVisualStyleBackColor = true;
            // 
            // SettingBtn
            // 
            SettingBtn.Dock = DockStyle.Top;
            SettingBtn.FlatAppearance.BorderSize = 0;
            SettingBtn.FlatStyle = FlatStyle.Flat;
            SettingBtn.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettingBtn.ForeColor = SystemColors.ActiveCaptionText;
            SettingBtn.Image = (Image)resources.GetObject("SettingBtn.Image");
            SettingBtn.ImageAlign = ContentAlignment.TopLeft;
            SettingBtn.Location = new Point(0, 170);
            SettingBtn.Name = "SettingBtn";
            SettingBtn.RightToLeft = RightToLeft.Yes;
            SettingBtn.Size = new Size(250, 40);
            SettingBtn.TabIndex = 4;
            SettingBtn.Text = "Settings Panel";
            SettingBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SettingBtn.UseVisualStyleBackColor = true;
            // 
            // FleetPandDashBoardBtn
            // 
            FleetPandDashBoardBtn.Dock = DockStyle.Top;
            FleetPandDashBoardBtn.FlatAppearance.BorderSize = 0;
            FleetPandDashBoardBtn.FlatStyle = FlatStyle.Flat;
            FleetPandDashBoardBtn.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FleetPandDashBoardBtn.ForeColor = SystemColors.ActiveCaptionText;
            FleetPandDashBoardBtn.Image = (Image)resources.GetObject("FleetPandDashBoardBtn.Image");
            FleetPandDashBoardBtn.ImageAlign = ContentAlignment.TopLeft;
            FleetPandDashBoardBtn.Location = new Point(0, 130);
            FleetPandDashBoardBtn.Name = "FleetPandDashBoardBtn";
            FleetPandDashBoardBtn.RightToLeft = RightToLeft.Yes;
            FleetPandDashBoardBtn.Size = new Size(250, 40);
            FleetPandDashBoardBtn.TabIndex = 3;
            FleetPandDashBoardBtn.Text = "FP Dashboard";
            FleetPandDashBoardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            FleetPandDashBoardBtn.UseVisualStyleBackColor = true;
            // 
            // QuickBridgeDashboardbtn
            // 
            QuickBridgeDashboardbtn.Dock = DockStyle.Top;
            QuickBridgeDashboardbtn.FlatAppearance.BorderSize = 0;
            QuickBridgeDashboardbtn.FlatStyle = FlatStyle.Flat;
            QuickBridgeDashboardbtn.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuickBridgeDashboardbtn.ForeColor = Color.Black;
            QuickBridgeDashboardbtn.Image = (Image)resources.GetObject("QuickBridgeDashboardbtn.Image");
            QuickBridgeDashboardbtn.ImageAlign = ContentAlignment.TopLeft;
            QuickBridgeDashboardbtn.Location = new Point(0, 90);
            QuickBridgeDashboardbtn.Name = "QuickBridgeDashboardbtn";
            QuickBridgeDashboardbtn.RightToLeft = RightToLeft.Yes;
            QuickBridgeDashboardbtn.Size = new Size(250, 40);
            QuickBridgeDashboardbtn.TabIndex = 2;
            QuickBridgeDashboardbtn.Text = "QB Dashboard";
            QuickBridgeDashboardbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            QuickBridgeDashboardbtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(Usernamelbl);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 90);
            panel2.TabIndex = 1;
            // 
            // Usernamelbl
            // 
            Usernamelbl.AutoSize = true;
            Usernamelbl.BackColor = Color.Transparent;
            Usernamelbl.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usernamelbl.ForeColor = Color.Black;
            Usernamelbl.Location = new Point(75, 63);
            Usernamelbl.Name = "Usernamelbl";
            Usernamelbl.Size = new Size(85, 22);
            Usernamelbl.TabIndex = 1;
            Usernamelbl.Text = "User Name";
            Usernamelbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 393);
            Controls.Add(panel1);
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label Usernamelbl;
        private Button QuickBridgeDashboardbtn;
        private Button FleetPandDashBoardBtn;
        private Button SettingBtn;
        private Button SyncedDatasBtn;
        private Button LogDetailsBtn;
        private Button button2;
        private Button button1;
    }
}