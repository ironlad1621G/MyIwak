namespace MyMyIwak.Models.Interfaces
{
    internal interface IPengelolaInventaris
    {
        void TambahStok(Ikan ikan, int jumlah);
        void UbahDataIkan(Ikan ikan, string jenis, string warna, int umur_bulan, string deskripsi);
        void UbahHarga(Ikan ikan, long harga_baru);
        void NonaktifkanIkan(Ikan ikan);
    }
}
