using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    internal class AkunRepositoryMemori : IAkunRepository
    {
        private readonly List<Akun> data = new();

        public int IdBerikutnya()
        {
            int max = 0;
            foreach (var a in data)
            {
                if (a.Id_akun > max)
                {
                    max = a.Id_akun;
                }
            }
            return max + 1;
        }

        public Akun? AmbilById(int id_akun)
        {
            foreach (var a in data)
            {
                if (a.Id_akun == id_akun)
                {
                    return a;
                }
            }
            return null;
        }

        public Akun? AmbilByUsername(string username)
        {
            foreach (var a in data)
            {
                if (string.Equals(a.Username, username, StringComparison.OrdinalIgnoreCase))
                {
                    return a;
                }
            }
            return null;
        }

        public List<Akun> AmbilByRole(Role role)
        {
            List<Akun> hasil = new();

            foreach (var a in data)
            {
                if (a.Role == role)
                {
                    hasil.Add(a);
                }
            }

            return hasil;
        }

        public bool AdaOwner()
        {
            return AmbilByRole(Role.Owner).Count > 0;
        }

        public void Tambah(Akun akun)
        {
            data.Add(akun);
        }

        public void Update(Akun akun)
        {
        }
    }
}
