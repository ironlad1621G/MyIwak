using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    public class IkanRepositoryMemori : IIkanRepository
    {
        private readonly List<Ikan> data = new();

        public List<Ikan> AmbilSemuaAktif()
        {
            List<Ikan> hasil = new();

            foreach (var i in data)
            {
                if (i.Is_active == true)
                {
                    hasil.Add(i);
                }
            }

            return hasil;
        }

        public Ikan? AmbilById(int id_ikan)
        {
            foreach (var i in data)
            {
                if (i.Id_ikan == id_ikan)
                {
                    return i;
                }
            }
            return null;
        }

        public void Tambah(Ikan ikan)
        {
            data.Add(ikan);
        }

        public void Update(Ikan ikan)
        {
        }
    }
}
