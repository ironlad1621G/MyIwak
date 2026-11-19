using MyMyIwak.Models;
using MyMyIwak.Repositories;

namespace MyMyIwak.Controllers
{
    public class IkanController
    {
        private readonly IIkanRepository repository;

        public IkanController(IIkanRepository repository)
        {
            this.repository = repository;
        }

        private void PastikanPengelola(Role peran)
        {
            if (peran != Role.Owner && peran != Role.Admin)
            {
                throw new UnauthorizedAccessException("Hanya Owner dan Admin yang bisa mengelola data ikan.");
            }
        }

        private Ikan AmbilIkanAktif(int id_ikan)
        {
            Ikan? ikan = repository.AmbilById(id_ikan);
            if (ikan == null || !ikan.Is_active)
            {
                throw new InvalidOperationException("Ikan tidak ditemukan.");
            }
            return ikan;
        }

        public List<Ikan> Katalog()
        {
            return repository.AmbilSemuaAktif();
        }

        public Ikan LihatIkan(int id_ikan)
        {
            return AmbilIkanAktif(id_ikan);
        }

        public void TambahIkan(Role peran, Ikan ikan)
        {
            PastikanPengelola(peran);

            if (ikan == null)
            {
                throw new ArgumentNullException(nameof(ikan));
            }

            repository.Tambah(ikan);
        }

        public void UbahIkan(Role peran, int id_ikan, string jenis, string warna, int umur_bulan, string deskripsi)
        {
            PastikanPengelola(peran);
            Ikan ikan = AmbilIkanAktif(id_ikan);

            ikan.Jenis = jenis;
            ikan.Warna = warna;
            ikan.Umur_bulan = umur_bulan;
            ikan.Deskripsi = deskripsi;

            repository.Update(ikan);
        }

        public void HapusIkan(Role peran, int id_ikan)
        {
            PastikanPengelola(peran);
            Ikan ikan = AmbilIkanAktif(id_ikan);

            ikan.Nonaktifkan();

            repository.Update(ikan);
        }

        public void TambahStok(Role peran, int id_ikan, int jumlah)
        {
            PastikanPengelola(peran);
            Ikan ikan = AmbilIkanAktif(id_ikan);

            ikan.TambahStok(jumlah);

            repository.Update(ikan);
        }
    }
}
