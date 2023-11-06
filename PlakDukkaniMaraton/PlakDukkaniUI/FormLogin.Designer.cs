namespace WinFormsApp1
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
            btn_Login = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_LoginPassword = new TextBox();
            txt_LoginUsername = new TextBox();
            btn_NewRegister = new Button();
            SuspendLayout();
            // 
            // cb_LoginPassword
            // 
            cb_LoginPassword.AutoSize = true;
            cb_LoginPassword.Location = new Point(196, 190);
            cb_LoginPassword.Name = "cb_LoginPassword";
            cb_LoginPassword.Size = new Size(119, 24);
            cb_LoginPassword.TabIndex = 10;
            cb_LoginPassword.Text = "Şifreyi Göster";
            cb_LoginPassword.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(251, 248);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(94, 29);
            btn_Login.TabIndex = 9;
            btn_Login.Text = "Giriş Yap";
            btn_Login.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 134);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 7;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 52);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 8;
            label1.Text = "Kullanıcı Adı";
            // 
            // txt_LoginPassword
            // 
            txt_LoginPassword.Location = new Point(220, 127);
            txt_LoginPassword.Name = "txt_LoginPassword";
            txt_LoginPassword.Size = new Size(125, 27);
            txt_LoginPassword.TabIndex = 5;
            // 
            // txt_LoginUsername
            // 
            txt_LoginUsername.Location = new Point(220, 46);
            txt_LoginUsername.Name = "txt_LoginUsername";
            txt_LoginUsername.Size = new Size(125, 27);
            txt_LoginUsername.TabIndex = 6;
            // 
            // btn_NewRegister
            // 
            btn_NewRegister.Location = new Point(61, 248);
            btn_NewRegister.Name = "btn_NewRegister";
            btn_NewRegister.Size = new Size(94, 29);
            btn_NewRegister.TabIndex = 9;
            btn_NewRegister.Text = "Yeni Kayıt";
            btn_NewRegister.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 330);
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
        private Button btn_Login;
        private Label label2;
        private Label label1;
        private TextBox txt_LoginPassword;
        private TextBox txt_LoginUsername;
        private Button btn_NewRegister;
    }
}