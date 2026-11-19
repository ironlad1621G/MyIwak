using MyMyIwak.Models;
using MyMyIwak.Repositories;

namespace MyMyIwak.Controllers

{
    internal class KeranjangController
    {
        private readonly IKeranjangRepository keranjangRepo;
        private readonly IIkanRepository ikanRepo;
        private readonly ILayananPengirimanRepository layananRepo;

        public KeranjangController(IKeranjangRepository keranjangRepo, IIkanRepository ikanRepo,
                                   ILayananPengirimanRepository layananRepo)
        {
            this.keranjangRepo = keranjangRepo;
            this.ikanRepo = ikanRepo;
            this.layananRepo = layananRepo;
        }

        private Ikan AmbilIkanAktif(int id_ikan)
        {
            Ikan? ikan = ikanRepo.AmbilById(id_ikan);
            if (ikan == null || !ikan.Is_active)
            {
                throw new InvalidOperationException("Ikan tidak ditemukan.");
            }
            return ikan;
        }

        private Keranjang AmbilMilik(Customer customer, int id_keranjang)
        {
            Keranjang? item = keranjangRepo.AmbilById(id_keranjang);
            if (item == null || item.Id_akun != customer.Id_akun)
            {
                throw new InvalidOperationException("Item keranjang tidak ditemukan.");
            }
            return item;
        }

        private static void PastikanStokCukup(Ikan ikan, int jumlah)
        {
            if (jumlah > ikan.Stok)
            {
                throw new InvalidOperationException($"Stok {ikan.Jenis} hanya tersisa {ikan.Stok}.");
            }
        }

        public List<Keranjang> IsiKeranjang(Customer customer)
        {
            return keranjangRepo.AmbilByAkun(customer.Id_akun);
        }

        public Keranjang TambahKeKeranjang(Customer customer, int id_ikan, int jumlah)
        {
            Ikan ikan = AmbilIkanAktif(id_ikan);
            Keranjang? item = keranjangRepo.AmbilByAkunDanIkan(customer.Id_akun, id_ikan);

            if (item != null)
            {
                PastikanStokCukup(ikan, item.Jumlah + jumlah);
                item.TambahJumlah(jumlah);
                keranjangRepo.Update(item);
                return item;
            }

            PastikanStokCukup(ikan, jumlah);
            Keranjang baru = new Keranjang(keranjangRepo.IdBerikutnya(), id_ikan, customer.Id_akun, jumlah);
            keranjangRepo.Tambah(baru);
            return baru;
        }

        public void UbahJumlah(Customer customer, int id_keranjang, int jumlah_baru)
        {
            Keranjang item = AmbilMilik(customer, id_keranjang);

            if (jumlah_baru <= 0)
            {
                keranjangRepo.Hapus(id_keranjang);
                return;
            }

            if (jumlah_baru > item.Jumlah)
            {
                PastikanStokCukup(AmbilIkanAktif(item.Id_ikan), jumlah_baru);
                item.TambahJumlah(jumlah_baru - item.Jumlah);
            }
            else if (jumlah_baru < item.Jumlah)
            {
                item.KurangiJumlah(item.Jumlah - jumlah_baru);
            }

            keranjangRepo.Update(item);
        }

        public void HapusDariKeranjang(Customer customer, int id_keranjang)
        {
            AmbilMilik(customer, id_keranjang);
            keranjangRepo.Hapus(id_keranjang);
        }

        public long HitungSubtotal(Keranjang item)
        {
            Ikan? ikan = ikanRepo.AmbilById(item.Id_ikan);
            if (ikan == null)
            {
                throw new InvalidOperationException("Ikan tidak ditemukan.");
            }
            return ikan.Harga * item.Jumlah;
        }

        public long HitungTotal(Customer customer)
        {
            long total = 0;
            foreach (var item in keranjangRepo.AmbilByAkun(customer.Id_akun))
            {
                total += HitungSubtotal(item);
            }
            return total;
        }

        public List<Layananpengiriman> DaftarLayananKirim()
        {
            return layananRepo.AmbilSemua();
        }
    }
}
