using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    public interface IPengirimanRepository
    {
        Pengiriman? AmbilByTransaksi(int id_transaksi);
        List<Pengiriman> AmbilByStatus(StatusPengiriman status);
        void UpdateStatus(Pengiriman pengiriman);
    }
}
