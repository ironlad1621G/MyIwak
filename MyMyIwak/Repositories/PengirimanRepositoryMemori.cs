using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    public class PengirimanRepositoryMemori : IPengirimanRepository
    {
        private readonly List<Pengiriman> data = new();

        public void Tambah(Pengiriman pengiriman)
        {
            data.Add(pengiriman);
        }

        public Pengiriman? AmbilByTransaksi(int id_transaksi)
        {
            foreach (var p in data)
            {
                if (p.IdTransaksi == id_transaksi)
                {
                    return p;
                }
            }
            return null;
        }

        public List<Pengiriman> AmbilByStatus(StatusPengiriman status)
        {
            List<Pengiriman> hasil = new();

            foreach (var p in data)
            {
                if (p.Status == status)
                {
                    hasil.Add(p);
                }
            }

            return hasil;
        }

        public void UpdateStatus(Pengiriman pengiriman)
        {
        }
    }
}
