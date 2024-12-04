namespace QuickBridge
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            Username_txtbox = new TextBox();
            Password_txtbox = new TextBox();
            Usernamelbl = new Label();
            Passwordlbl = new Label();
            Login_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Username_txtbox
            // 
            Username_txtbox.Location = new Point(88, 169);
            Username_txtbox.Name = "Username_txtbox";
            Username_txtbox.Size = new Size(178, 27);
            Username_txtbox.TabIndex = 1;
            // 
            // Password_txtbox
            // 
            Password_txtbox.Location = new Point(88, 239);
            Password_txtbox.Name = "Password_txtbox";
            Password_txtbox.PasswordChar = '*';
            Password_txtbox.Size = new Size(178, 27);
            Password_txtbox.TabIndex = 2;
            // 
            // Usernamelbl
            // 
            Usernamelbl.AutoSize = true;
            Usernamelbl.Location = new Point(88, 146);
            Usernamelbl.Name = "Usernamelbl";
            Usernamelbl.Size = new Size(75, 20);
            Usernamelbl.TabIndex = 3;
            Usernamelbl.Text = "Username";
            // 
            // Passwordlbl
            // 
            Passwordlbl.AutoSize = true;
            Passwordlbl.Location = new Point(92, 209);
            Passwordlbl.Name = "Passwordlbl";
            Passwordlbl.Size = new Size(87, 20);
            Passwordlbl.TabIndex = 4;
            Passwordlbl.Text = "Finalversion";
            // 
            // Login_Btn
            // 
            Login_Btn.BackColor = SystemColors.ControlLightLight;
            Login_Btn.Location = new Point(114, 285);
            Login_Btn.Name = "Login_Btn";
            Login_Btn.Size = new Size(94, 29);
            Login_Btn.TabIndex = 5;
            Login_Btn.Text = "Login";
            Login_Btn.UseVisualStyleBackColor = false;
            Login_Btn.Click += Login_Btn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 351);
            Controls.Add(Login_Btn);
            Controls.Add(Passwordlbl);
            Controls.Add(Usernamelbl);
            Controls.Add(Password_txtbox);
            Controls.Add(Username_txtbox);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox Username_txtbox;
        private TextBox Password_txtbox;
        private Label Usernamelbl;
        private Label Passwordlbl;
        private Button Login_Btn;
    }
}