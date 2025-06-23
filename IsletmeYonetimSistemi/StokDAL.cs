using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


public class StokDAL
{

    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\MASAÜSTÜ UYGULAMASI\IsletmeDB.mdf;Integrated Security=True;Connect Timeout=30";

    public List<Stok> StoklariGetir()
    {
        List<Stok> liste = new List<Stok>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT * FROM Stoklar ORDER BY Id DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                liste.Add(new Stok
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    UrunAdi = reader["UrunAdi"].ToString(),
                    StokMiktari = Convert.ToInt32(reader["StokMiktari"]),
                    Birim = reader["Birim"].ToString(),
                    AlisFiyati = Convert.ToDecimal(reader["AlisFiyati"]),
                    SatisFiyati = Convert.ToDecimal(reader["SatisFiyati"]),
                    Tedarikci = reader["Tedarikci"].ToString(),
                    KayitTarihi = Convert.ToDateTime(reader["KayitTarihi"])
                });
            }
        }
        return liste;
    }

    public void StokEkle(Stok s)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = @"INSERT INTO Stoklar (UrunAdi, StokMiktari, Birim, AlisFiyati, SatisFiyati, Tedarikci, KayitTarihi)
                             VALUES (@UrunAdi, @StokMiktari, @Birim, @AlisFiyati, @SatisFiyati, @Tedarikci, @KayitTarihi)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UrunAdi", s.UrunAdi);
            cmd.Parameters.AddWithValue("@StokMiktari", s.StokMiktari);
            cmd.Parameters.AddWithValue("@Birim", s.Birim);
            cmd.Parameters.AddWithValue("@AlisFiyati", s.AlisFiyati);
            cmd.Parameters.AddWithValue("@SatisFiyati", s.SatisFiyati);
            cmd.Parameters.AddWithValue("@Tedarikci", s.Tedarikci);
            cmd.Parameters.AddWithValue("@KayitTarihi", s.KayitTarihi);
            cmd.ExecuteNonQuery();
        }
    }

    public void StokGuncelle(Stok s)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = @"UPDATE Stoklar SET 
                             UrunAdi=@UrunAdi, 
                             StokMiktari=@StokMiktari,
                             Birim=@Birim,
                             AlisFiyati=@AlisFiyati,
                             SatisFiyati=@SatisFiyati,
                             Tedarikci=@Tedarikci
                             WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UrunAdi", s.UrunAdi);
            cmd.Parameters.AddWithValue("@StokMiktari", s.StokMiktari);
            cmd.Parameters.AddWithValue("@Birim", s.Birim);
            cmd.Parameters.AddWithValue("@AlisFiyati", s.AlisFiyati);
            cmd.Parameters.AddWithValue("@SatisFiyati", s.SatisFiyati);
            cmd.Parameters.AddWithValue("@Tedarikci", s.Tedarikci);
            cmd.Parameters.AddWithValue("@Id", s.Id);
            cmd.ExecuteNonQuery();
        }
    }

    public void StokSil(int id)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "DELETE FROM Stoklar WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
