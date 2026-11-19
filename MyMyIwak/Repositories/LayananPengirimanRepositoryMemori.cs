using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    public class LayananPengirimanRepositoryMemori : ILayananPengirimanRepository
    {
        private readonly List<Layananpengiriman> data = new();

        public List<Layananpengiriman> AmbilSemua()
        {
            return new List<Layananpengiriman>(data);
        }

        public Layananpengiriman? AmbilById(int id_layanan)
        {
            foreach (var l in data)
            {
                if (l.IdLayanan == id_layanan)
                {
                    return l;
                }
            }
            return null;
        }

        public void Tambah(Layananpengiriman layanan)
        {
            data.Add(layanan);
        }
    }
}
