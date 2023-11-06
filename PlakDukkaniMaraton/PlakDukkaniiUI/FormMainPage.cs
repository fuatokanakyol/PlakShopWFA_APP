using PlakDukkaniData.Entities;
using PlakDukkaniSERVICE.AlbumService;
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
    public partial class FormMainPage : Form
    {
        AlbumService albumService = new AlbumService();
        Album album;
        Album selectedAlbum;


        public FormMainPage()
        {
            InitializeComponent();
        }

        private void DGVFill(ICollection<Album> albumListe)
        {
            dataGridView1.DataSource = albumListe;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.ClearSelection();
        }

        private void FormMainPage_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Methods.Functions.IsEmptyArea(this.Controls))
                {
                    album = new Album()
                    {
                        AlbumName = txt_name.Text.Trim(),
                        Musician = txt_musiciannn.Text.Trim(),
                        ReleaseDate = dtp_rlsdate.Value,
                        Price = Convert.ToDouble(txt_price.Text.Trim()),
                        Discount = Convert.ToDouble(nud_dsc.Text.Trim()),
                        IsItOnSale = rdb_onsale.Checked == true ? true : false
                    };

                    albumService.Add(album);
                    MessageBox.Show("Album kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGVFill(albumService.GetAll());
                    Methods.Functions.Clear(this.Controls);
                }
                else
                {
                    MessageBox.Show("Boş alan bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu,tekrar deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                selectedAlbum.AlbumName = txt_name.Text.Trim();
                selectedAlbum.Musician = txt_Musician.Text.Trim();
                selectedAlbum.ReleaseDate = dtp_rlsdate.Value;
                selectedAlbum.Price = Convert.ToDouble(txt_price.Text.Trim());
                selectedAlbum.Discount = Convert.ToDouble(nud_dsc.Text.Trim());
                selectedAlbum.IsItOnSale = rdb_onsale.Checked == true ? true : false;

                albumService.Update(selectedAlbum);
                MessageBox.Show("Album güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill(albumService.GetAll());
                Methods.Functions.Clear(this.Controls);

            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu,tekrar deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string columnName = "Id";
                int idValue = Convert.ToInt32(selectedRow.Cells[columnName].Value);
                var selectedAlbum = albumService.GetById(idValue);

                albumService.Remove(selectedAlbum);
                MessageBox.Show("Album silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill(albumService.GetAll());
                Methods.Functions.Clear(this.Controls);

            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu,tekrar deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            DGVFill(albumService.GetAll());
        }

        private void btn_NotForSale_Click(object sender, EventArgs e)
        {
            var filteredAlbums = albumService.GetByCondition(x => x.IsItOnSale == false).Select(x => new Album { AlbumName = x.AlbumName, Musician = x.Musician }).ToList(); DGVFill(filteredAlbums);
        }

        private void btn_OnSale_Click(object sender, EventArgs e)
        {
            DGVFill(albumService.GetByCondition(x => x.IsItOnSale == true));
        }

        private void btn_Top10_Click(object sender, EventArgs e)
        {
            DGVFill(albumService.Top10(10));
        }

        private void btn_Discounted_Click(object sender, EventArgs e)
        {
            DGVFill(albumService.GetByCondition(x => x.Discount > 0));
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string columnName = "Id";
                int idValue = Convert.ToInt32(selectedRow.Cells[columnName].Value);
                selectedAlbum = albumService.GetById(idValue);

                txt_AlbumName.Text = selectedAlbum.AlbumName;
                txt_Musician.Text = selectedAlbum.Musician;
                dtp_rlsdate.Value = selectedAlbum.ReleaseDate;
                txt_price.Text = selectedAlbum.Price.ToString();
                nud_dsc.Value = Convert.ToDecimal(selectedAlbum.Discount);
                rdb_onsale.Checked = selectedAlbum.IsItOnSale == true ? true : false;
                rdb_notsale.Checked = selectedAlbum.IsItOnSale == true ? false : true;
            }
        }
    }
}
