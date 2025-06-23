using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

public class SiparisDAL
{
    //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\MASAÜSTÜ UYGULAMASI\IsletmeDB.mdf;Integrated Security=True;Connect Timeout=30";
    //
     string connectionString = "server=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\LENOVO\\DESKTOP\\MASAÜSTÜ UYGULAMASI\\ISLETMEDB.MDF;Integrated Security=SSPI";

    public List<Siparis> SiparisleriGetir()
    {
        List<Siparis> liste = new List<Siparis>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = @"
                SELECT s.Id, s.MusteriId, m.AdSoyad AS MusteriAdSoyad, 
                       s.SiparisTarihi, s.Durum, s.Aciklama
                FROM Siparisler s
                INNER JOIN Musteriler m ON s.MusteriId = m.Id
                ORDER BY s.Id DESC";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                liste.Add(new Siparis
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    MusteriId = Convert.ToInt32(reader["MusteriId"]),
                    MusteriAdSoyad = reader["MusteriAdSoyad"].ToString(),
                    SiparisTarihi = Convert.ToDateTime(reader["SiparisTarihi"]),
                    Durum = reader["Durum"].ToString(),
                    Aciklama = reader["Aciklama"].ToString()
                });
            }
        }

        return liste;
    }

    public void SiparisEkle(Siparis s)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = @"INSERT INTO Siparisler (MusteriId, SiparisTarihi, Durum, Aciklama)
                             VALUES (@MusteriId, @SiparisTarihi, @Durum, @Aciklama)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MusteriId", s.MusteriId);
            cmd.Parameters.AddWithValue("@SiparisTarihi", s.SiparisTarihi);
            cmd.Parameters.AddWithValue("@Durum", s.Durum);
            cmd.Parameters.AddWithValue("@Aciklama", s.Aciklama);
            cmd.ExecuteNonQuery();
        }
    }

    public void SiparisGuncelle(Siparis s)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = @"UPDATE Siparisler 
                             SET MusteriId=@MusteriId, SiparisTarihi=@SiparisTarihi, Durum=@Durum, Aciklama=@Aciklama 
                             WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MusteriId", s.MusteriId);
            cmd.Parameters.AddWithValue("@SiparisTarihi", s.SiparisTarihi);
            cmd.Parameters.AddWithValue("@Durum", s.Durum);
            cmd.Parameters.AddWithValue("@Aciklama", s.Aciklama);
            cmd.Parameters.AddWithValue("@Id", s.Id);
            cmd.ExecuteNonQuery();
        }
    }

    public void SiparisSil(int id)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "DELETE FROM Siparisler WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
