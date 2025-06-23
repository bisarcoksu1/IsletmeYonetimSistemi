public class Siparis
{
    public int Id { get; set; }
    public int MusteriId { get; set; }
    public string MusteriAdSoyad { get; set; } // UI için kolaylık
    public DateTime SiparisTarihi { get; set; }
    public string Durum { get; set; }
    public string Aciklama { get; set; }
}
