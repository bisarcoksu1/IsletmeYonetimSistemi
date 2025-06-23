using System;
using System.Windows.Forms;

namespace IsletmeYonetimSistemi
{
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
        }

        MusteriDAL musteriDAL = new MusteriDAL();
        int seciliMusteriId = 0;

        private void FormMusteriler_Load(object sender, EventArgs e)
        {
            MusterileriListele();
        }

        private void MusterileriListele()
        {
            dataGridView1.DataSource = musteriDAL.MusterileriGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                MessageBox.Show("Ad Soyad boş olamaz.");
                return;
            }

            Musteri m = new Musteri
            {
                AdSoyad = txtAdSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtEmail.Text,
                Adres = txtAdres.Text,
                KayitTarihi = DateTime.Now,
                Sifre = txtSifre.Text
            };

            musteriDAL.MusteriEkle(m);
            MessageBox.Show("Müşteri eklendi.");
            MusterileriListele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliMusteriId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek müşteriyi seçin.");
                return;
            }

            Musteri m = new Musteri
            {
                Id = seciliMusteriId,
                AdSoyad = txtAdSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtEmail.Text,
                Adres = txtAdres.Text,
                KayitTarihi = DateTime.Now,
                Sifre = txtSifre.Text// Güncellerken gerek olmayabilir ama burada örnek
            };

            musteriDAL.MusteriGuncelle(m);
            MessageBox.Show("Müşteri güncellendi.");
            MusterileriListele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliMusteriId == 0)
            {
                MessageBox.Show("Lütfen silinecek müşteriyi seçin.");
                return;
            }

            var onay = MessageBox.Show("Müşteri silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                musteriDAL.MusteriSil(seciliMusteriId);
                MessageBox.Show("Müşteri silindi.");
                MusterileriListele();
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
            txtSifre.Clear();

            seciliMusteriId = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                seciliMusteriId = Convert.ToInt32(row.Cells["Id"].Value);
                txtAdSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAdres.Text = row.Cells["Adres"].Value.ToString();
            }
        }
    }
}
