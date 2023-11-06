namespace PlakDukkaniiUI
{
    partial class FormRegister
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
            cb_LoginPassword = new CheckBox();
            btn_Back = new Button();
            btn_Register = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_pw1 = new TextBox();
            txt_registername = new TextBox();
            txt_pw2 = new TextBox();
            asdasd = new Label();
            SuspendLayout();
            // 
            // cb_LoginPassword
            // 
            cb_LoginPassword.AutoSize = true;
            cb_LoginPassword.Location = new Point(165, 132);
            cb_LoginPassword.Margin = new Padding(3, 2, 3, 2);
            cb_LoginPassword.Name = "cb_LoginPassword";
            cb_LoginPassword.Size = new Size(95, 19);
            cb_LoginPassword.TabIndex = 17;
            cb_LoginPassword.Text = "Şifreyi Göster";
            cb_LoginPassword.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(46, 176);
            btn_Back.Margin = new Padding(3, 2, 3, 2);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(82, 22);
            btn_Back.TabIndex = 19;
            btn_Back.Text = "Geri";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(213, 176);
            btn_Register.Margin = new Padding(3, 2, 3, 2);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(82, 22);
            btn_Register.TabIndex = 18;
            btn_Register.Text = "Kayıt";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 67);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 20;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 29);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 21;
            label1.Text = "Kullanıcı Adı";
            // 
            // txt_pw1
            // 
            txt_pw1.Location = new Point(185, 67);
            txt_pw1.Margin = new Padding(3, 2, 3, 2);
            txt_pw1.Name = "txt_pw1";
            txt_pw1.PasswordChar = '*';
            txt_pw1.Size = new Size(110, 23);
            txt_pw1.TabIndex = 16;
            // 
            // txt_registername
            // 
            txt_registername.Location = new Point(185, 24);
            txt_registername.Margin = new Padding(3, 2, 3, 2);
            txt_registername.Name = "txt_registername";
            txt_registername.Size = new Size(110, 23);
            txt_registername.TabIndex = 15;
            // 
            // txt_pw2
            // 
            txt_pw2.Location = new Point(185, 94);
            txt_pw2.Margin = new Padding(3, 2, 3, 2);
            txt_pw2.Name = "txt_pw2";
            txt_pw2.PasswordChar = '*';
            txt_pw2.Size = new Size(110, 23);
            txt_pw2.TabIndex = 16;
            // 
            // asdasd
            // 
            asdasd.AutoSize = true;
            asdasd.Location = new Point(48, 94);
            asdasd.Name = "asdasd";
            asdasd.Size = new Size(64, 15);
            asdasd.TabIndex = 20;
            asdasd.Text = "Şifre Tekrar";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 273);
            Controls.Add(cb_LoginPassword);
            Controls.Add(btn_Back);
            Controls.Add(btn_Register);
            Controls.Add(asdasd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_pw2);
            Controls.Add(txt_pw1);
            Controls.Add(txt_registername);
            Name = "FormRegister";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cb_LoginPassword;
        private Button btn_Back;
        private Button btn_Register;
        private Label label2;
        private Label label1;
        private TextBox txt_pw1;
        private TextBox txt_registername;
        private TextBox txt_pw2;
        private Label asdasd;
    }
}