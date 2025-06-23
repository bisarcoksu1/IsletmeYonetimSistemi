using System;
using System.Windows.Forms;

namespace IsletmeYonetimSistemi
{
    public partial class FormStoklar : Form
    {
        public FormStoklar()
        {
            InitializeComponent();
        }

        StokDAL stokDAL = new StokDAL();
        int seciliStokId = 0;

        private void FormStoklar_Load(object sender, EventArgs e)
        {
            StoklariListele();
        }

        private void StoklariListele()
        {
            dataGridView1.DataSource = stokDAL.StoklariGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz.");
                return;
            }

            Stok s = new Stok
            {
                UrunAdi = txtUrunAdi.Text,
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                Birim = txtBirim.Text,
                AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text),
                SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text),
                Tedarikci = txtTedarikci.Text,
                KayitTarihi = DateTime.Now
            };

            stokDAL.StokEkle(s);
            MessageBox.Show("Stok eklendi.");
            StoklariListele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliStokId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek ürünü seçin.");
                return;
            }

            Stok s = new Stok
            {
                Id = seciliStokId,
                UrunAdi = txtUrunAdi.Text,
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                Birim = txtBirim.Text,
                AlisFiyati = Convert.ToDecimal(txtAlisFiyati.Text),
                SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text),
                Tedarikci = txtTedarikci.Text,
                KayitTarihi = DateTime.Now
            };

            stokDAL.StokGuncelle(s);
            MessageBox.Show("Stok güncellendi.");
            StoklariListele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliStokId == 0)
            {
                MessageBox.Show("Lütfen silinecek ürünü seçin.");
                return;
            }

            var onay = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                stokDAL.StokSil(seciliStokId);
                MessageBox.Show("Stok silindi.");
                StoklariListele();
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtUrunAdi.Clear();
            txtStokMiktari.Clear();
            txtBirim.Clear();
            txtAlisFiyati.Clear();
            txtSatisFiyati.Clear();
            txtTedarikci.Clear();
            seciliStokId = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                seciliStokId = Convert.ToInt32(row.Cells["Id"].Value);
                txtUrunAdi.Text = row.Cells["UrunAdi"].Value.ToString();
                txtStokMiktari.Text = row.Cells["StokMiktari"].Value.ToString();
                txtBirim.Text = row.Cells["Birim"].Value.ToString();
                txtAlisFiyati.Text = row.Cells["AlisFiyati"].Value.ToString();
                txtSatisFiyati.Text = row.Cells["SatisFiyati"].Value.ToString();
                txtTedarikci.Text = row.Cells["Tedarikci"].Value.ToString();
            }
        }
    }
}
