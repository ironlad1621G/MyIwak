using MyMyIwak.Models.Interfaces;

namespace MyMyIwak.Models
{
    internal class Admin : Akun, IPengelolaInventaris
    {
        public Admin(int id_akun, string username, string nama_lengkap, string password, string no_telepon, string alamat, bool is_active)
            : base(id_akun, username, nama_lengkap, password, no_telepon, alamat, is_active)
        {
        }

        public override Role Role
        {
            get { return Role.Admin; }
        }

        public void TambahStok(Ikan ikan, int jumlah)
        {
            ikan.TambahStok(jumlah);
        }

        public void UbahDataIkan(Ikan ikan, string jenis, string warna, int umur_bulan, string deskripsi)
        {
            ikan.Jenis = jenis;
            ikan.Warna = warna;
            ikan.Umur_bulan = umur_bulan;
            ikan.Deskripsi = deskripsi;
        }

        public void UbahHarga(Ikan ikan, long harga_baru)
        {
            ikan.Harga = harga_baru;
        }

        public void NonaktifkanIkan(Ikan ikan)
        {
            ikan.Nonaktifkan();
        }
    }
}
