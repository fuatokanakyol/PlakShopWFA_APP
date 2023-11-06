using PlakDukkaniData.Entities;
using PlakDukkaniiUI.Methods;
using PlakDukkaniSERVICE.ManagerService;

namespace PlakDukkaniiUI
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string username = txt_registername.Text.Trim();
            string password = txt_pw1.Text.Trim();
            Manager manager = new Manager();
            ManagerService managerService = new ManagerService();
            try
            {
                if (!Methods.Functions.IsEmptyArea(this.Controls))
                {
                    if (managerService.GetByCondition(x => x.UserName == username).Any())
                    {
                        MessageBox.Show("Ge�ersiz kullan�c� ad� girdiniz, tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Methods.Functions.Clear(this.Controls);
                    }
                    if (!Methods.Functions.PasswordCheck(password))
                    {
                        MessageBox.Show("�ifreniz olu�turulamad� tekrar deneyiniz.\n�ifre kurallar�:\r\n� En az 8 karakter uzunlu�unda olmal�d�r.\r\n� En az 1 b�y�k harf i�ermelidir.\r\n� En az 1 k���k harf i�ermelidir.\r\n�En az 1 �zel karakter i�ermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        manager.UserName = username;
                        manager.Password = Hashing.HasHing(password, manager.UserName);
                        managerService.Add(manager);

                        FormLogin frm = new FormLogin();
                        frm.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Bo� alan b�rakmay�n�z, tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata, tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin frm = new FormLogin();
            frm.Show();

        }
    }
}