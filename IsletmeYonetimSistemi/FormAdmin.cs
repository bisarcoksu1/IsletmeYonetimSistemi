using GöreselProgramlama_Proje;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsletmeYonetimSistemi
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            this.Load += FormAdmin_Load;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            AdminDAL adminDAL = new AdminDAL();

            if (adminDAL.AdminGirisKontrol(kullaniciAdi, sifre))
            {
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAnaMenu anaMenu = new FormAnaMenu();
                anaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti; sqlbaglanti sqlbaglanti = new sqlbaglanti();
        SqlCommand komut;

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            try
            {
                komut = new SqlCommand("select * from Musteriler where Email = @epsota and Sifre = @sifre", baglanti = sqlbaglanti.baglantiOn());
                komut.Parameters.AddWithValue("@epsota", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);

                SqlDataReader dr;
                //baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.GetValue(6).ToString()=="1")
                    {
                        MessageBox.Show("Girmiş Başarılı...");
                        Form FormAnaMenu = new FormAnaMenu();
                        FormAnaMenu.Show();
                        this.Hide();
                        sqlbaglanti.baglantiOff(baglanti);
                    }
                    else
                    {
                        MessageBox.Show("Girmiş Başarısız..");
                    }

                    break;

                }
            }
            catch (Exception ex)
            {
                sqlbaglanti.baglantiOff(baglanti);
                MessageBox.Show(ex.Message);
            }

        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';

            }
            else
            {
                txtSifre.PasswordChar = '*';

            }
        }
    }
}
