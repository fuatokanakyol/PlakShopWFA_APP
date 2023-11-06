namespace PlakDukkaniiUI
{
    partial class FormLogin
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
            cb_LoginPassword = new CheckBox();
            btn_NewRegister = new Button();
            btn_Login = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_LoginPassword = new TextBox();
            txt_LoginUsername = new TextBox();
            SuspendLayout();
            // 
            // cb_LoginPassword
            // 
            cb_LoginPassword.AutoSize = true;
            cb_LoginPassword.Location = new Point(148, 133);
            cb_LoginPassword.Margin = new Padding(3, 2, 3, 2);
            cb_LoginPassword.Name = "cb_LoginPassword";
            cb_LoginPassword.Size = new Size(95, 19);
            cb_LoginPassword.TabIndex = 3;
            cb_LoginPassword.Text = "Şifreyi Göster";
            cb_LoginPassword.UseVisualStyleBackColor = true;
            cb_LoginPassword.CheckedChanged += cb_LoginPassword_CheckedChanged;
            // 
            // btn_NewRegister
            // 
            btn_NewRegister.Location = new Point(29, 177);
            btn_NewRegister.Margin = new Padding(3, 2, 3, 2);
            btn_NewRegister.Name = "btn_NewRegister";
            btn_NewRegister.Size = new Size(82, 22);
            btn_NewRegister.TabIndex = 5;
            btn_NewRegister.Text = "Yeni Kayıt";
            btn_NewRegister.UseVisualStyleBackColor = true;
            btn_NewRegister.Click += btn_NewRegister_Click;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(196, 177);
            btn_Login.Margin = new Padding(3, 2, 3, 2);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(82, 22);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Giriş Yap";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 91);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 13;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 14;
            label1.Text = "Kullanıcı Adı";
            // 
            // txt_LoginPassword
            // 
            txt_LoginPassword.Location = new Point(168, 86);
            txt_LoginPassword.Margin = new Padding(3, 2, 3, 2);
            txt_LoginPassword.Name = "txt_LoginPassword";
            txt_LoginPassword.PasswordChar = '*';
            txt_LoginPassword.Size = new Size(110, 23);
            txt_LoginPassword.TabIndex = 2;
            // 
            // txt_LoginUsername
            // 
            txt_LoginUsername.Location = new Point(168, 25);
            txt_LoginUsername.Margin = new Padding(3, 2, 3, 2);
            txt_LoginUsername.Name = "txt_LoginUsername";
            txt_LoginUsername.Size = new Size(110, 23);
            txt_LoginUsername.TabIndex = 1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 270);
            Controls.Add(cb_LoginPassword);
            Controls.Add(btn_NewRegister);
            Controls.Add(btn_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_LoginPassword);
            Controls.Add(txt_LoginUsername);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cb_LoginPassword;
        private Button btn_NewRegister;
        private Button btn_Login;
        private Label label2;
        private Label label1;
        private TextBox txt_LoginPassword;
        private TextBox txt_LoginUsername;
    }
}