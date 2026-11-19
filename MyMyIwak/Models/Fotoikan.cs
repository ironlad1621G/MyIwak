using System;
using System.Collections.Generic;
using System.Text;

namespace MyMyIwak.Models
{
    internal class FotoIkan : Entitas
    {
        private int id_ikan;
        private string gambar = "";

        public int Id_foto_ikan
        {
            get { return Id; }
        }
        public int Id_ikan
        {
            get { return id_ikan; }
            private set { id_ikan = value; }
        }
        public string Gambar
        {
            get { return gambar; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Gambar tidak boleh kosong");
                }
                else
                {
                    gambar = value;
                }
            }
        }
        public FotoIkan(int id_foto_ikan, int id_ikan, string gambar) : base(id_foto_ikan)
        {
            this.Id_ikan = id_ikan;
            this.Gambar = gambar;
        }

        public override string Deskripsikan()
        {
            return $"Foto #{Id} untuk ikan #{Id_ikan}: {Gambar}";
        }
    }
}
