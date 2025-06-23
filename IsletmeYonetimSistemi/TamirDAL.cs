using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


public class TamirDAL
{
    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\MASAÜSTÜ UYGULAMASI\IsletmeDB.mdf;Integrated Security=True;Connect Timeout=30";

    public List<TamirKaydi> TamirKayitlariGetir()
    {
        List<TamirKaydi> liste = new List<TamirKaydi>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = @"
                SELECT t.*, m.AdSoyad AS MusteriAdSoyad
                FROM TamirKayitlari t
                INNER JOIN Musteriler m ON t.MusteriId = m.Id
                ORDER BY t.Id DESC";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                liste.Add(new TamirKaydi
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    MusteriId = Convert.ToInt32(reader["MusteriId"]),
                    MusteriAdSoyad = reader["MusteriAdSoyad"].ToString(),
                    CihazBilgisi = reader["CihazBilgisi"].ToString(),
                    ArizaAciklama = reader["ArizaAciklama"].ToString(),
                    YapilanIslem = reader["YapilanIslem"].ToString(),
                    Durum = reader["Durum"].ToString(),
                    GirisTarihi = Convert.ToDateTime(reader["GirisTarihi"]),
                    TeslimTarihi = reader["TeslimTarihi"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["TeslimTarihi"])
                });
            }
        }

        return liste;
    }

    public void TamirEkle(TamirKaydi t)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = @"INSERT INTO TamirKayitlari (MusteriId, CihazBilgisi, ArizaAciklama, YapilanIslem, Durum, GirisTarihi, TeslimTarihi)
                             VALUES (@MusteriId, @CihazBilgisi, @ArizaAciklama, @YapilanIslem, @Durum, @GirisTarihi, @TeslimTarihi)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MusteriId", t.MusteriId);
            cmd.Parameters.AddWithValue("@CihazBilgisi", t.CihazBilgisi);
            cmd.Parameters.AddWithValue("@ArizaAciklama", t.ArizaAciklama);
            cmd.Parameters.AddWithValue("@YapilanIslem", t.YapilanIslem);
            cmd.Parameters.AddWithValue("@Durum", t.Durum);
            cmd.Parameters.AddWithValue("@GirisTarihi", t.GirisTarihi);
            cmd.Parameters.AddWithValue("@TeslimTarihi", (object?)t.TeslimTarihi ?? DBNull.Value);
            cmd.ExecuteNonQuery();
        }
    }

    public void TamirGuncelle(TamirKaydi t)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = @"UPDATE TamirKayitlari 
                             SET MusteriId=@MusteriId, CihazBilgisi=@CihazBilgisi, ArizaAciklama=@ArizaAciklama,
                                 YapilanIslem=@YapilanIslem, Durum=@Durum, GirisTarihi=@GirisTarihi, TeslimTarihi=@TeslimTarihi
                             WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MusteriId", t.MusteriId);
            cmd.Parameters.AddWithValue("@CihazBilgisi", t.CihazBilgisi);
            cmd.Parameters.AddWithValue("@ArizaAciklama", t.ArizaAciklama);
            cmd.Parameters.AddWithValue("@YapilanIslem", t.YapilanIslem);
            cmd.Parameters.AddWithValue("@Durum", t.Durum);
            cmd.Parameters.AddWithValue("@GirisTarihi", t.GirisTarihi);
            cmd.Parameters.AddWithValue("@TeslimTarihi", (object?)t.TeslimTarihi ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Id", t.Id);
            cmd.ExecuteNonQuery();
        }
    }

    public void TamirSil(int id)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "DELETE FROM TamirKayitlari WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
