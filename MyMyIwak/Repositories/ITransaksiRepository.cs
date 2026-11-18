using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    public interface ITransaksiRepository
    {
        Transaksi? AmbilById(int id_transaksi);
        List<Transaksi> AmbilByAkun(int id_akun);
        List<Transaksi> AmbilMenungguValidasi();
        void UpdateStatus(Transaksi transaksi);
    }
}