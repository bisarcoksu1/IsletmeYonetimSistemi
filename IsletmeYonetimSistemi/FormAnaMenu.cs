using System;
using System.Windows.Forms;

namespace IsletmeYonetimSistemi
{
    public partial class FormAnaMenu : Form
    {
        public FormAnaMenu()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FormMusteriler frm = new FormMusteriler();
            frm.ShowDialog();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            FormStoklar frm = new FormStoklar();
            frm.ShowDialog();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            FormSiparisler frm = new FormSiparisler();
            frm.ShowDialog();
        }

        private void btnTamir_Click(object sender, EventArgs e)
        {
            FormTamirler frm = new FormTamirler();
            frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
