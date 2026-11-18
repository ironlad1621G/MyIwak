using MyMyIwak.Models;
using MyMyIwak.Repositories;
using System.Data;

namespace MyMyIwak.Controllers
{
    public class PengirimanController
    {
        private readonly IPengirimanRepository pengirimanRepo;
        private readonly ITransaksiRepository transaksiRepo;

        public PengirimanController(IPengirimanRepository pengirimanRepo, ITransaksiRepository transaksiRepo)
        {
            this.pengirimanRepo = pengirimanRepo;
            this.transaksiRepo = transaksiRepo;
        }

        public void KemasPesanan(Role peran, int id_transaksi)
        {
            if (peran != Role.Admin)
            {
                throw new UnauthorizedAccessException("Hanya Admin yang bisa mengemas pesanan.");
            }

            Transaksi? transaksi = transaksiRepo.AmbilById(id_transaksi);
            if (transaksi == null)
            {
                throw new InvalidOperationException("Transaksi tidak ditemukan.");
            }

            if (transaksi.StatusPembayaran != StatusPembayaran.Lunas)
            {
                throw new InvalidOperationException("Pembayaran belum divalidasi, pesanan belum boleh dikemas.");
            }

            Pengiriman? pengiriman = pengirimanRepo.AmbilByTransaksi(id_transaksi);
            if (pengiriman == null)
            {
                throw new InvalidOperationException("Data pengiriman tidak ditemukan.");
            }

            pengiriman.Kemas();
            pengirimanRepo.UpdateStatus(pengiriman);
        }

        public void KirimPesanan(Role peran, int id_transaksi)
        {
            if (peran != Role.Admin)
            {
                throw new UnauthorizedAccessException("");
            }
            Pengiriman? pengiriman = pengirimanRepo.AmbilByTransaksi(id_transaksi);
            if (pengiriman == null)
            {
                throw new ArgumentException("ga ada");
            }
            pengiriman.Kirim(DateTime.Now);
            pengirimanRepo.UpdateStatus(pengiriman);
        }

        public void KonfirmasiSudahSampai(Role peran, int id_akun, int id_transaksi)
        {
            if (peran != Role.Customer)
            {
                throw new UnauthorizedAccessException("ente bukan customer cik");
            }
            Transaksi? transaksi = transaksiRepo.AmbilById(id_transaksi);
            if (transaksi == null)
            {
                throw new InvalidOperationException("Transaksi tidak ditemukan.");
            }
            if (transaksi.IdAkun != id_akun)
            {
                throw new ArgumentException("Ini bukan pesananmu");
            }
            Pengiriman? pengiriman = pengirimanRepo.AmbilByTransaksi(id_transaksi);
            if(pengiriman == null)
            {
                throw new ArgumentException("opo to rek");
            }
            pengiriman.KonfirmasiDiterima(DateTime.Now);
            pengirimanRepo.UpdateStatus(pengiriman);
        }
    }
}