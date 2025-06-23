namespace IsletmeYonetimSistemi
{
    partial class FormTamirler
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTamirler));
            cmbMusteri = new ComboBox();
            txtCihaz = new TextBox();
            txtAriza = new TextBox();
            txtIslem = new TextBox();
            cmbDurum = new ComboBox();
            dtpGiris = new DateTimePicker();
            dtpTeslim = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            lblMusteri = new Label();
            lblCihaz = new Label();
            lblAriza = new Label();
            lblIslem = new Label();
            lblDurum = new Label();
            lblGiris = new Label();
            lblTeslim = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbMusteri
            // 
            cmbMusteri.Anchor = AnchorStyles.Top;
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.Location = new Point(120, 20);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(200, 28);
            cmbMusteri.TabIndex = 0;
            // 
            // txtCihaz
            // 
            txtCihaz.Anchor = AnchorStyles.Top;
            txtCihaz.Location = new Point(120, 60);
            txtCihaz.Name = "txtCihaz";
            txtCihaz.Size = new Size(200, 27);
            txtCihaz.TabIndex = 1;
            // 
            // txtAriza
            // 
            txtAriza.Anchor = AnchorStyles.Top;
            txtAriza.Location = new Point(120, 100);
            txtAriza.Name = "txtAriza";
            txtAriza.Size = new Size(200, 27);
            txtAriza.TabIndex = 2;
            // 
            // txtIslem
            // 
            txtIslem.Anchor = AnchorStyles.Top;
            txtIslem.Location = new Point(120, 140);
            txtIslem.Name = "txtIslem";
            txtIslem.Size = new Size(200, 27);
            txtIslem.TabIndex = 3;
            // 
            // cmbDurum
            // 
            cmbDurum.Anchor = AnchorStyles.Top;
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.Items.AddRange(new object[] { "Bekliyor", "Tamirde", "Teslim Edildi" });
            cmbDurum.Location = new Point(120, 180);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(200, 28);
            cmbDurum.TabIndex = 4;
            // 
            // dtpGiris
            // 
            dtpGiris.Anchor = AnchorStyles.Top;
            dtpGiris.Location = new Point(120, 220);
            dtpGiris.Name = "dtpGiris";
            dtpGiris.Size = new Size(200, 27);
            dtpGiris.TabIndex = 5;
            // 
            // dtpTeslim
            // 
            dtpTeslim.Anchor = AnchorStyles.Top;
            dtpTeslim.Location = new Point(120, 260);
            dtpTeslim.Name = "dtpTeslim";
            dtpTeslim.Size = new Size(200, 27);
            dtpTeslim.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(20, 310);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(745, 200);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Top;
            btnEkle.BackColor = Color.Red;
            btnEkle.Location = new Point(343, 70);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 30);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Anchor = AnchorStyles.Top;
            btnGuncelle.BackColor = Color.Yellow;
            btnGuncelle.Location = new Point(343, 110);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 30);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top;
            btnSil.BackColor = Color.Lime;
            btnSil.Location = new Point(343, 150);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 30);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Anchor = AnchorStyles.Top;
            btnTemizle.BackColor = Color.Cyan;
            btnTemizle.Location = new Point(343, 190);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(100, 30);
            btnTemizle.TabIndex = 10;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lblMusteri
            // 
            lblMusteri.Anchor = AnchorStyles.Top;
            lblMusteri.Location = new Point(20, 20);
            lblMusteri.Name = "lblMusteri";
            lblMusteri.Size = new Size(100, 23);
            lblMusteri.TabIndex = 12;
            lblMusteri.Text = "Müşteri:";
            // 
            // lblCihaz
            // 
            lblCihaz.Anchor = AnchorStyles.Top;
            lblCihaz.Location = new Point(20, 60);
            lblCihaz.Name = "lblCihaz";
            lblCihaz.Size = new Size(100, 23);
            lblCihaz.TabIndex = 13;
            lblCihaz.Text = "Cihaz:";
            // 
            // lblAriza
            // 
            lblAriza.Anchor = AnchorStyles.Top;
            lblAriza.Location = new Point(20, 100);
            lblAriza.Name = "lblAriza";
            lblAriza.Size = new Size(100, 23);
            lblAriza.TabIndex = 14;
            lblAriza.Text = "Arıza:";
            // 
            // lblIslem
            // 
            lblIslem.Anchor = AnchorStyles.Top;
            lblIslem.Location = new Point(20, 140);
            lblIslem.Name = "lblIslem";
            lblIslem.Size = new Size(100, 23);
            lblIslem.TabIndex = 15;
            lblIslem.Text = "Yapılan İşlem:";
            // 
            // lblDurum
            // 
            lblDurum.Anchor = AnchorStyles.Top;
            lblDurum.Location = new Point(20, 180);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(100, 23);
            lblDurum.TabIndex = 16;
            lblDurum.Text = "Durum:";
            // 
            // lblGiris
            // 
            lblGiris.Anchor = AnchorStyles.Top;
            lblGiris.Location = new Point(20, 220);
            lblGiris.Name = "lblGiris";
            lblGiris.Size = new Size(100, 23);
            lblGiris.TabIndex = 17;
            lblGiris.Text = "Giriş Tarihi:";
            // 
            // lblTeslim
            // 
            lblTeslim.Anchor = AnchorStyles.Top;
            lblTeslim.Location = new Point(20, 260);
            lblTeslim.Name = "lblTeslim";
            lblTeslim.Size = new Size(100, 23);
            lblTeslim.TabIndex = 18;
            lblTeslim.Text = "Teslim Tarihi:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(472, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // FormTamirler
            // 
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(788, 540);
            Controls.Add(pictureBox1);
            Controls.Add(cmbMusteri);
            Controls.Add(txtCihaz);
            Controls.Add(txtAriza);
            Controls.Add(txtIslem);
            Controls.Add(cmbDurum);
            Controls.Add(dtpGiris);
            Controls.Add(dtpTeslim);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnTemizle);
            Controls.Add(dataGridView1);
            Controls.Add(lblMusteri);
            Controls.Add(lblCihaz);
            Controls.Add(lblAriza);
            Controls.Add(lblIslem);
            Controls.Add(lblDurum);
            Controls.Add(lblGiris);
            Controls.Add(lblTeslim);
            ForeColor = Color.Black;
            Name = "FormTamirler";
            Text = "Tamir Süreci Yönetimi";
            Load += FormTamirler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.TextBox txtCihaz;
        private System.Windows.Forms.TextBox txtAriza;
        private System.Windows.Forms.TextBox txtIslem;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.DateTimePicker dtpTeslim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblCihaz;
        private System.Windows.Forms.Label lblAriza;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Label lblTeslim;
        private PictureBox pictureBox1;
    }
}
