using System;
using System.Collections.Generic;
using System.Text;

namespace MyMyIwak.Models
{
    internal class Keranjang
    {
        private int id_keranjang;
        private int id_ikan;
        private int id_akun;
        private int jumlah;

        public int Id_keranjang
        {
            get { return id_keranjang; }
            private set { id_keranjang = value; }
        }
        public int Id_ikan
        {
            get { return id_ikan; }
            private set { id_ikan = value; }
        }
        public int Id_akun
        {
            get { return id_akun; }
            private set { id_akun = value; }
        }
        public int Jumlah
        {
            get { return jumlah; }
            private set { jumlah = value; }
        }
        public Keranjang(int id_keranjang, int id_ikan, int id_akun, int jumlah)
        {
            this.id_keranjang = id_keranjang;
            this.id_ikan = id_ikan;
            this.id_akun = id_akun;
            this.jumlah = jumlah;
        }
    }
}
