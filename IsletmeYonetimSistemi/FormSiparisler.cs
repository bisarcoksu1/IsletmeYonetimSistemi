using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IsletmeYonetimSistemi
{
    public partial class FormSiparisler : Form
    {
        public FormSiparisler()
        {
            InitializeComponent();
        }

        SiparisDAL siparisDAL = new SiparisDAL();
        MusteriDAL musteriDAL = new MusteriDAL(); // müşteri listesi için
        int seciliSiparisId = 0;

        private void FormSiparisler_Load(object sender, EventArgs e)
        {
            MusteriListele();
            SiparisListele();
        }

        private void MusteriListele()
        {
            var musteriler = musteriDAL.MusterileriGetir();
            cmbMusteri.DataSource = musteriler;
            cmbMusteri.DisplayMember = "AdSoyad";
            cmbMusteri.ValueMember = "Id";
        }

        private void SiparisListele()
        {
            dataGridView1.DataSource = siparisDAL.SiparisleriGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis
            {
                MusteriId = Convert.ToInt32(cmbMusteri.SelectedValue),
                SiparisTarihi = dtpTarih.Value,
                Durum = cmbDurum.Text,
                Aciklama = txtAciklama.Text
            };

            siparisDAL.SiparisEkle(s);
            MessageBox.Show("Sipariş eklendi.");
            SiparisListele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliSiparisId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek siparişi seçin.");
                return;
            }

            Siparis s = new Siparis
            {
                Id = seciliSiparisId,
                MusteriId = Convert.ToInt32(cmbMusteri.SelectedValue),
                SiparisTarihi = dtpTarih.Value,
                Durum = cmbDurum.Text,
                Aciklama = txtAciklama.Text
            };

            siparisDAL.SiparisGuncelle(s);
            MessageBox.Show("Sipariş güncellendi.");
            SiparisListele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliSiparisId == 0)
            {
                MessageBox.Show("Lütfen silinecek siparişi seçin.");
                return;
            }

            var onay = MessageBox.Show("Bu siparişi silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                siparisDAL.SiparisSil(seciliSiparisId);
                MessageBox.Show("Sipariş silindi.");
                SiparisListele();
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            cmbMusteri.SelectedIndex = 0;
            cmbDurum.SelectedIndex = 0;
            txtAciklama.Clear();
            dtpTarih.Value = DateTime.Now;
            seciliSiparisId = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                seciliSiparisId = Convert.ToInt32(row.Cells["Id"].Value);
                cmbMusteri.Text = row.Cells["MusteriAdSoyad"].Value.ToString();
                dtpTarih.Value = Convert.ToDateTime(row.Cells["SiparisTarihi"].Value);
                cmbDurum.Text = row.Cells["Durum"].Value.ToString();
                txtAciklama.Text = row.Cells["Aciklama"].Value.ToString();
            }
        }
    }
}
