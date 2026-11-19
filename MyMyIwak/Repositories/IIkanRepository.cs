using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    public interface IIkanRepository
    {
        List<Ikan> AmbilSemuaAktif();
        Ikan? AmbilById(int id_ikan);
        void Tambah(Ikan ikan);
        void Update(Ikan ikan);
    }
}
