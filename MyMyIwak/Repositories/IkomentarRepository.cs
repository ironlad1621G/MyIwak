using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    internal interface IKomentarRepository
    {
        int IdBerikutnya();
        Komentar? AmbilById(int id_komentar);
        List<Komentar> AmbilAktifByIkan(int id_ikan);
        void Tambah(Komentar komentar);
        void Update(Komentar komentar);
    }
}
