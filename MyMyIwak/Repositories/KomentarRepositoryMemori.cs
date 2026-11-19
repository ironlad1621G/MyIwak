using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    internal class KomentarRepositoryMemori : IKomentarRepository
    {
        private readonly List<Komentar> data = new();

        public int IdBerikutnya()
        {
            int max = 0;
            foreach (var k in data)
            {
                if (k.Id_komentar > max)
                {
                    max = k.Id_komentar;
                }
            }
            return max + 1;
        }

        public Komentar? AmbilById(int id_komentar)
        {
            foreach (var k in data)
            {
                if (k.Id_komentar == id_komentar)
                {
                    return k;
                }
            }
            return null;
        }

        public List<Komentar> AmbilAktifByIkan(int id_ikan)
        {
            List<Komentar> hasil = new();

            foreach (var k in data)
            {
                if (k.Id_ikan == id_ikan && k.Is_active)
                {
                    hasil.Add(k);
                }
            }

            return hasil;
        }

        public void Tambah(Komentar komentar)
        {
            data.Add(komentar);
        }

        public void Update(Komentar komentar)
        {
        }
    }
}
