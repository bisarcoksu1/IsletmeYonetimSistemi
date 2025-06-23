using System;
using System.Windows.Forms;

namespace IsletmeYonetimSistemi
{
    public partial class FormTamirler : Form
    {
        public FormTamirler()
        {
            InitializeComponent();
        }

        TamirDAL tamirDAL = new TamirDAL();
        MusteriDAL musteriDAL = new MusteriDAL();
        int seciliTamirId = 0;

        private void FormTamirler_Load(object sender, EventArgs e)
        {
            MusteriListele();
            TamirListele();
        }

        private void MusteriListele()
        {
            cmbMusteri.DataSource = musteriDAL.MusterileriGetir();
            cmbMusteri.DisplayMember = "AdSoyad";
            cmbMusteri.ValueMember = "Id";
        }

        private void TamirListele()
        {
            dataGridView1.DataSource = tamirDAL.TamirKayitlariGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TamirKaydi t = new TamirKaydi
            {
                MusteriId = Convert.ToInt32(cmbMusteri.SelectedValue),
                CihazBilgisi = txtCihaz.Text,
                ArizaAciklama = txtAriza.Text,
                YapilanIslem = txtIslem.Text,
                Durum = cmbDurum.Text,
                GirisTarihi = dtpGiris.Value,
                TeslimTarihi = dtpTeslim.Value
            };

            tamirDAL.TamirEkle(t);
            MessageBox.Show("Tamir kaydı eklendi.");
            TamirListele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliTamirId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçin.");
                return;
            }

            TamirKaydi t = new TamirKaydi
            {
                Id = seciliTamirId,
                MusteriId = Convert.ToInt32(cmbMusteri.SelectedValue),
                CihazBilgisi = txtCihaz.Text,
                ArizaAciklama = txtAriza.Text,
                YapilanIslem = txtIslem.Text,
                Durum = cmbDurum.Text,
                GirisTarihi = dtpGiris.Value,
                TeslimTarihi = dtpTeslim.Value
            };

            tamirDAL.TamirGuncelle(t);
            MessageBox.Show("Tamir kaydı güncellendi.");
            TamirListele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliTamirId == 0)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçin.");
                return;
            }

            var onay = MessageBox.Show("Bu tamir kaydını silmek istiyor musun?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                tamirDAL.TamirSil(seciliTamirId);
                MessageBox.Show("Tamir kaydı silindi.");
                TamirListele();
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtCihaz.Clear();
            txtAriza.Clear();
            txtIslem.Clear();
            cmbDurum.SelectedIndex = 0;
            dtpGiris.Value = DateTime.Now;
            dtpTeslim.Value = DateTime.Now;
            cmbMusteri.SelectedIndex = 0;
            seciliTamirId = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                seciliTamirId = Convert.ToInt32(row.Cells["Id"].Value);
                cmbMusteri.Text = row.Cells["MusteriAdSoyad"].Value.ToString();
                txtCihaz.Text = row.Cells["CihazBilgisi"].Value.ToString();
                txtAriza.Text = row.Cells["ArizaAciklama"].Value.ToString();
                txtIslem.Text = row.Cells["YapilanIslem"].Value.ToString();
                cmbDurum.Text = row.Cells["Durum"].Value.ToString();
                dtpGiris.Value = Convert.ToDateTime(row.Cells["GirisTarihi"].Value);
                dtpTeslim.Value = row.Cells["TeslimTarihi"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["TeslimTarihi"].Value)
                    : DateTime.Now;
            }
        }
    }
}
