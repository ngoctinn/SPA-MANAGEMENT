namespace GUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            btnShowHidePassword = new Guna.UI2.WinForms.Guna2ImageButton();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label2 = new Label();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(guna2ControlBox1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(363, 30);
            guna2Panel1.TabIndex = 0;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.BackColor = Color.Transparent;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.Dock = DockStyle.Right;
            guna2ControlBox1.FillColor = SystemColors.Info;
            guna2ControlBox1.HoverState.FillColor = Color.FromArgb(54, 128, 45);
            guna2ControlBox1.HoverState.IconColor = Color.White;
            guna2ControlBox1.IconColor = Color.FromArgb(54, 128, 45);
            guna2ControlBox1.Location = new Point(333, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(30, 30);
            guna2ControlBox1.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BackgroundImage = Properties.Resources.wave__3_;
            guna2Panel2.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Panel2.Controls.Add(btnShowHidePassword);
            guna2Panel2.Controls.Add(btnLogin);
            guna2Panel2.Controls.Add(txtPassword);
            guna2Panel2.CustomizableEdges = customizableEdges10;
            guna2Panel2.Location = new Point(-216, 197);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges11;
            guna2Panel2.Size = new Size(828, 442);
            guna2Panel2.TabIndex = 1;
            guna2Panel2.Paint += guna2Panel2_Paint;
            // 
            // btnShowHidePassword
            // 
            btnShowHidePassword.BackColor = Color.White;
            btnShowHidePassword.CheckedState.ImageSize = new Size(64, 64);
            btnShowHidePassword.HoverState.Image = Properties.Resources.icons8_show_password_251;
            btnShowHidePassword.HoverState.ImageSize = new Size(25, 25);
            btnShowHidePassword.Image = Properties.Resources.icons8_show_password_25;
            btnShowHidePassword.ImageOffset = new Point(0, 0);
            btnShowHidePassword.ImageRotate = 0F;
            btnShowHidePassword.ImageSize = new Size(25, 25);
            btnShowHidePassword.Location = new Point(459, 3);
            btnShowHidePassword.Name = "btnShowHidePassword";
            btnShowHidePassword.PressedState.ImageSize = new Size(26, 26);
            btnShowHidePassword.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnShowHidePassword.Size = new Size(61, 43);
            btnShowHidePassword.TabIndex = 5;
            btnShowHidePassword.Click += btnShowHidePassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.CustomizableEdges = customizableEdges6;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(54, 128, 45);
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverState.FillColor = Color.FromArgb(70, 100, 40);
            btnLogin.Location = new Point(270, 77);
            btnLogin.Name = "btnLogin";
            btnLogin.PressedColor = Color.FromArgb(35, 77, 32);
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnLogin.Size = new Size(250, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.FromArgb(54, 128, 45);
            txtPassword.BorderRadius = 5;
            txtPassword.CustomizableEdges = customizableEdges8;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(54, 128, 45);
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.HoverState.BorderColor = Color.FromArgb(54, 128, 45);
            txtPassword.IconLeft = Properties.Resources.icons8_passwords_30;
            txtPassword.IconLeftSize = new Size(25, 25);
            txtPassword.Location = new Point(270, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges9;
            txtPassword.Size = new Size(250, 45);
            txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += guna2TextBox2_TextChanged;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderColor = Color.FromArgb(54, 128, 45);
            guna2TextBox1.BorderRadius = 5;
            guna2TextBox1.CustomizableEdges = customizableEdges12;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(54, 128, 45);
            guna2TextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(54, 128, 45);
            guna2TextBox1.IconLeft = Properties.Resources.icons8_user_50;
            guna2TextBox1.IconLeftSize = new Size(25, 25);
            guna2TextBox1.Location = new Point(54, 149);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "Username";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges13;
            guna2TextBox1.Size = new Size(250, 45);
            guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            guna2TextBox1.TabIndex = 0;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(117, 58);
            label1.Name = "label1";
            label1.Size = new Size(128, 35);
            label1.TabIndex = 3;
            label1.Text = "Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ScrollBar;
            label2.Location = new Point(117, 93);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 4;
            label2.Text = "Sign In To Continue";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(363, 452);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowHidePassword;
    }
}