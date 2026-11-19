using MyMyIwak.Models;
using MyMyIwak.Repositories;

namespace MyMyIwak.Controllers

{
    internal class KomentarController
    {
        private readonly IKomentarRepository komentarRepo;
        private readonly IIkanRepository ikanRepo;

        public KomentarController(IKomentarRepository komentarRepo, IIkanRepository ikanRepo)
        {
            this.komentarRepo = komentarRepo;
            this.ikanRepo = ikanRepo;
        }

        private void PastikanIkanAktif(int id_ikan)
        {
            Ikan? ikan = ikanRepo.AmbilById(id_ikan);
            if (ikan == null || !ikan.Is_active)
            {
                throw new InvalidOperationException("Ikan tidak ditemukan.");
            }
        }

        private Komentar AmbilKomentarAktif(int id_komentar)
        {
            Komentar? komentar = komentarRepo.AmbilById(id_komentar);
            if (komentar == null || !komentar.Is_active)
            {
                throw new InvalidOperationException("Komentar tidak ditemukan.");
            }
            return komentar;
        }

        private Komentar Simpan(Akun penulis, int id_ikan, string isi)
        {
            PastikanIkanAktif(id_ikan);
            Komentar komentar = new Komentar(komentarRepo.IdBerikutnya(), penulis.Id_akun, id_ikan,
                                             isi, DateTime.Now, true);
            komentarRepo.Tambah(komentar);
            return komentar;
        }

        public List<Komentar> DaftarKomentar(int id_ikan)
        {
            return komentarRepo.AmbilAktifByIkan(id_ikan);
        }

        public Komentar TulisKomentar(Customer customer, int id_ikan, string isi)
        {
            return Simpan(customer, id_ikan, isi);
        }

        public Komentar BalasKomentar(Admin admin, int id_komentar, string isi)
        {
            Komentar asal = AmbilKomentarAktif(id_komentar);
            return Simpan(admin, asal.Id_ikan, isi);
        }

        public void UbahKomentar(Customer customer, int id_komentar, string isi)
        {
            Komentar komentar = AmbilKomentarAktif(id_komentar);
            if (komentar.Id_akun != customer.Id_akun)
            {
                throw new UnauthorizedAccessException("Hanya penulis komentar yang bisa mengubahnya.");
            }
            komentar.UpdateKomentar(isi);
            komentarRepo.Update(komentar);
        }

        public void HapusKomentar(Admin admin, int id_komentar)
        {
            Komentar komentar = AmbilKomentarAktif(id_komentar);
            komentar.HapusKomentar();
            komentarRepo.Update(komentar);
        }
    }
}
