using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    internal interface IKeranjangRepository
    {
        int IdBerikutnya();
        Keranjang? AmbilById(int id_keranjang);
        Keranjang? AmbilByAkunDanIkan(int id_akun, int id_ikan);
        List<Keranjang> AmbilByAkun(int id_akun);
        void Tambah(Keranjang keranjang);
        void Update(Keranjang keranjang);
        void Hapus(int id_keranjang);
    }
}
