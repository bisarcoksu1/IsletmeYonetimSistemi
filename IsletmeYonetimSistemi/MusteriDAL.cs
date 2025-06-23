using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


public class MusteriDAL
{
    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\MASAÜSTÜ UYGULAMASI\IsletmeDB.mdf;Integrated Security=True;Connect Timeout=30";


    public List<Musteri> MusterileriGetir()
    {
        List<Musteri> musteriler = new List<Musteri>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT * FROM Musteriler ORDER BY Id DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                musteriler.Add(new Musteri
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    AdSoyad = reader["AdSoyad"].ToString(),
                    Telefon = reader["Telefon"].ToString(),
                    Email = reader["Email"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    KayitTarihi = Convert.ToDateTime(reader["KayitTarihi"]),
                    Sifre = "***"

                });
            }
        }
        //tamamdır hocamştan yapmamız son olarak setup kurabilir misiniz bu programı tamam hocam Allah razı olsun şimdi geriye bişi kalmadı dimi yok sadece rol ve şifre ekledin onlarında ekleme güncelleme kodlarını yazdım  
        return musteriler;
    }

    public void MusteriEkle(Musteri m)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Musteriler  VALUES (@AdSoyad, @Telefon, @Email, @Adres, @KayitTarihi,@RolID,@Sifre)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AdSoyad", m.AdSoyad);
            cmd.Parameters.AddWithValue("@Telefon", m.Telefon);
            cmd.Parameters.AddWithValue("@Email", m.Email);
            cmd.Parameters.AddWithValue("@Adres", m.Adres);
            cmd.Parameters.AddWithValue("@KayitTarihi", m.KayitTarihi);
            cmd.Parameters.AddWithValue("@Sifre", m.Sifre);
            cmd.Parameters.AddWithValue("@RolID", "2");


            cmd.ExecuteNonQuery();
        }
    }//eklemişsinya :d

    public void MusteriGuncelle(Musteri m)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "UPDATE Musteriler SET AdSoyad=@AdSoyad, Telefon=@Telefon, Sifre=@Sifre,Email=@Email, Adres=@Adres WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AdSoyad", m.AdSoyad);
            cmd.Parameters.AddWithValue("@Telefon", m.Telefon);
            cmd.Parameters.AddWithValue("@Email", m.Email);
            cmd.Parameters.AddWithValue("@Adres", m.Adres);
            cmd.Parameters.AddWithValue("@Id", m.Id);
            cmd.Parameters.AddWithValue("@Sifre", m.Sifre);

            cmd.ExecuteNonQuery();
        }
    }

    public void MusteriSil(int id)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "DELETE FROM Musteriler WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
