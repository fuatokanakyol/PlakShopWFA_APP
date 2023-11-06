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
                        MessageBox.Show("Geçersiz kullanýcý adý girdiniz, tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Methods.Functions.Clear(this.Controls);
                    }
                    if (!Methods.Functions.PasswordCheck(password))
                    {
                        MessageBox.Show("Þifreniz oluþturulamadý tekrar deneyiniz.\nÞifre kurallarý:\r\n• En az 8 karakter uzunluðunda olmalýdýr.\r\n• En az 1 büyük harf içermelidir.\r\n• En az 1 küçük harf içermelidir.\r\n•En az 1 özel karakter içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Boþ alan býrakmayýnýz, tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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