using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using IsletmeYonetimSistemi;
using Microsoft.Data.SqlClient;

public class AdminDAL
{
    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\MASAÜSTÜ UYGULAMASI\IsletmeDB.mdf;Integrated Security=True;Connect Timeout=30";

    public bool AdminGirisKontrol(string kullaniciAdi, string sifre)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM Adminler WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", sifre);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
    }
}

