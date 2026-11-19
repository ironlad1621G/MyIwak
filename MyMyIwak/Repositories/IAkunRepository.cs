using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    internal interface IAkunRepository
    {
        int IdBerikutnya();
        Akun? AmbilById(int id_akun);
        Akun? AmbilByUsername(string username);
        List<Akun> AmbilByRole(Role role);
        bool AdaOwner();
        void Tambah(Akun akun);
        void Update(Akun akun);
    }
}
