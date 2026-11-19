using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    public interface ILayananPengirimanRepository
    {
        List<Layananpengiriman> AmbilSemua();
        Layananpengiriman? AmbilById(int id_layanan);
        void Tambah(Layananpengiriman layanan);
    }
}
