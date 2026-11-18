using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    public class TransaksiRepositoryMemori : ITransaksiRepository
    {
        private readonly List<Transaksi> data = new();

        public void Tambah(Transaksi transaksi)
        {
            data.Add(transaksi);
        }

        public Transaksi? AmbilById(int id_transaksi)
        {
            foreach (var t in data)
            {
                if (t.IdTransaksi == id_transaksi)
                {
                    return t;
                }
            }
            return null;
        }

        public List<Transaksi> AmbilByAkun(int id_akun)
        {
            List<Transaksi> hasil = new();
            
            foreach(var t in data)
            {
                
                if (t.IdAkun == id_akun)
                {
                    hasil.Add(t);
                }
            }
            return hasil;
        }

        public List<Transaksi> AmbilMenungguValidasi()
        {
            List<Transaksi> hasil = new();

            foreach (var t in data)
            {

                if (t.StatusPembayaran == StatusPembayaran.Menunggu)
                {
                    hasil.Add(t);
                }
            }
            return hasil;
        }

        public void UpdateStatus(Transaksi transaksi)
        {
        }
    }
}