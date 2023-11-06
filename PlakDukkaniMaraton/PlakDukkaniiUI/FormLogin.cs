using PlakDukkaniData.Entities;
using PlakDukkaniSERVICE.ManagerService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniiUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        ManagerService managerService = new ManagerService();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!Methods.Functions.IsEmptyArea(this.Controls))
            {
                if (managerService.GetByCondition(x => x.UserName == txt_LoginUsername.Text.Trim() && x.Password == Hashing.HasHing(txt_LoginPassword.Text.Trim(), txt_LoginUsername.Text.Trim())).Any())
                {
                    FormMainPage frm = new FormMainPage();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifresi girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifresi boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_NewRegister_Click(object sender, EventArgs e)
        {
            FormRegister frm = new FormRegister();
            frm.Show();
            this.Hide();
        }

        private void cb_LoginPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_LoginPassword.PasswordChar=cb_LoginPassword.Checked ? '\0' : '*';
        }
    }
}
