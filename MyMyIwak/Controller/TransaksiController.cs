using MyMyIwak.Models;
using MyMyIwak.Repositories;


namespace MyMyIwak.Controllers
{
    public class TransaksiController
    {
        private ITransaksiRepository repository;

        public TransaksiController(ITransaksiRepository repository)
        {
            this.repository = repository;
        }

        public void ValidasiPembayaran(Role peran, int id_transaksi)
        {
            if (peran != Role.Admin)
            {
                throw new UnauthorizedAccessException("Hanya Admin yang bisa memvalidasi pembayaran.");
            }
            Transaksi? transaksi = repository.AmbilById(id_transaksi);
            if(transaksi == null)
            {
                throw new InvalidOperationException("Transaksi Tidak Ditemukan");
            }
            transaksi.Lunasi(DateTime.Now);
            repository.UpdateStatus(transaksi);
        }

        public void TolakPembayaran(Role peran, int id_transaksi)
        {
            if (peran != Role.Admin)
            {
                throw new UnauthorizedAccessException("Hanyaa Admin Ynag Bisa Menolak Pembayaran");
            }
            Transaksi? transaksi = repository.AmbilById(id_transaksi);
            if (transaksi == null)
            {
                throw new InvalidOperationException("Transaksi Tidak Ditemukan");
            }
            transaksi.Tolak();
            repository.UpdateStatus(transaksi); 
            
        }
        public List<Transaksi> DaftarMenungguValidasi(Role peran)
        {
            if (peran != Role.Admin)
            {
                throw new UnauthorizedAccessException("Hanya Admin yang bisa melihat daftar validasi.");
            }

            return repository.AmbilMenungguValidasi();
        }
        public List<Transaksi> RiwayatSaya(Role peran, int id_akun)
        {
            if (peran != Role.Customer)
            {
                throw new UnauthorizedAccessException("Hanya Customer yang punya riwayat belanja");
            }
            return repository.AmbilByAkun(id_akun);
        }
    }
}