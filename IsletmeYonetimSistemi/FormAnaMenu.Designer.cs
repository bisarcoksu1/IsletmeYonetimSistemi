namespace IsletmeYonetimSistemi
{
    partial class FormAnaMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnMusteri = new Button();
            btnStok = new Button();
            btnSiparis = new Button();
            btnTamir = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // btnMusteri
            // 
            btnMusteri.Anchor = AnchorStyles.Top;
            btnMusteri.AutoSize = true;
            btnMusteri.BackColor = Color.Cyan;
            btnMusteri.Location = new Point(50, 30);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Size = new Size(200, 40);
            btnMusteri.TabIndex = 0;
            btnMusteri.Text = "Müşteri Takibi";
            btnMusteri.UseVisualStyleBackColor = false;
            btnMusteri.Click += btnMusteri_Click;
            // 
            // btnStok
            // 
            btnStok.Anchor = AnchorStyles.Top;
            btnStok.AutoSize = true;
            btnStok.BackColor = Color.Lime;
            btnStok.Location = new Point(50, 80);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(200, 40);
            btnStok.TabIndex = 1;
            btnStok.Text = "Stok Takibi";
            btnStok.UseVisualStyleBackColor = false;
            btnStok.Click += btnStok_Click;
            // 
            // btnSiparis
            // 
            btnSiparis.Anchor = AnchorStyles.Top;
            btnSiparis.AutoSize = true;
            btnSiparis.BackColor = Color.FromArgb(255, 128, 0);
            btnSiparis.Location = new Point(50, 130);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(200, 40);
            btnSiparis.TabIndex = 2;
            btnSiparis.Text = "Sipariş Yönetimi";
            btnSiparis.UseVisualStyleBackColor = false;
            btnSiparis.Click += btnSiparis_Click;
            // 
            // btnTamir
            // 
            btnTamir.Anchor = AnchorStyles.Top;
            btnTamir.AutoSize = true;
            btnTamir.BackColor = Color.FromArgb(192, 0, 192);
            btnTamir.Location = new Point(50, 180);
            btnTamir.Name = "btnTamir";
            btnTamir.Size = new Size(200, 40);
            btnTamir.TabIndex = 3;
            btnTamir.Text = "Tamir Süreci";
            btnTamir.UseVisualStyleBackColor = false;
            btnTamir.Click += btnTamir_Click;
            // 
            // btnCikis
            // 
            btnCikis.Anchor = AnchorStyles.Top;
            btnCikis.AutoSize = true;
            btnCikis.BackColor = Color.Red;
            btnCikis.Location = new Point(50, 230);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(200, 40);
            btnCikis.TabIndex = 4;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // FormAnaMenu
            // 
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(300, 320);
            Controls.Add(btnMusteri);
            Controls.Add(btnStok);
            Controls.Add(btnSiparis);
            Controls.Add(btnTamir);
            Controls.Add(btnCikis);
            Name = "FormAnaMenu";
            Text = "İşletme Yönetim Sistemi";
            Load += FormAnaMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnTamir;
        private System.Windows.Forms.Button btnCikis;
    }
}
