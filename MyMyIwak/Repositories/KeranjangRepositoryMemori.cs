using MyMyIwak.Models;

namespace MyMyIwak.Repositories
{
    internal class KeranjangRepositoryMemori : IKeranjangRepository
    {
        private readonly List<Keranjang> data = new();

        public int IdBerikutnya()
        {
            int max = 0;
            foreach (var k in data)
            {
                if (k.Id_keranjang > max)
                {
                    max = k.Id_keranjang;
                }
            }
            return max + 1;
        }

        public Keranjang? AmbilById(int id_keranjang)
        {
            foreach (var k in data)
            {
                if (k.Id_keranjang == id_keranjang)
                {
                    return k;
                }
            }
            return null;
        }

        public Keranjang? AmbilByAkunDanIkan(int id_akun, int id_ikan)
        {
            foreach (var k in data)
            {
                if (k.Id_akun == id_akun && k.Id_ikan == id_ikan)
                {
                    return k;
                }
            }
            return null;
        }

        public List<Keranjang> AmbilByAkun(int id_akun)
        {
            List<Keranjang> hasil = new();

            foreach (var k in data)
            {
                if (k.Id_akun == id_akun)
                {
                    hasil.Add(k);
                }
            }

            return hasil;
        }

        public void Tambah(Keranjang keranjang)
        {
            data.Add(keranjang);
        }

        public void Update(Keranjang keranjang)
        {
        }

        public void Hapus(int id_keranjang)
        {
            Keranjang? k = AmbilById(id_keranjang);
            if (k != null)
            {
                data.Remove(k);
            }
        }
    }
}
