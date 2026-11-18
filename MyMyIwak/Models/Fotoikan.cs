using System;
using System.Collections.Generic;
using System.Text;

namespace MyMyIwak.Models
{
    internal class FotoIkan
    {
        private int id_foto_ikan;
        private int id_ikan;
        private string gambar;

        public int Id_foto_ikan
        {
            get { return id_foto_ikan; }
            private set { id_foto_ikan = value; }
        }
        public int Id_ikan
        {
            get { return id_ikan; }
            private set { id_ikan = value; }
        }
        public string Gambar
        {
            get { return gambar; }
            set { gambar = value; }
        }
        public FotoIkan(int id_foto_ikan,int id_ikan, string gambar)
        {
            this.Id_foto_ikan = id_foto_ikan;
            this.Id_ikan = id_ikan;
            this.Gambar = gambar;
        }
    }
}
