using System;
using System.Collections.Generic;
using System.Text;

namespace MyMyIwak.Models
{
    internal class Ikan
    {
        private int id_ikan;
        private string jenis;
        private string warna;
        private int umur_bulan;
        private int stok;
        private string deskripsi;
        private Boolean is_active;

        public int Id_ikan
        {
            get { return id_ikan; }
            private set { id_ikan = value; }
        }
        public string Jenis
        {
            get { return jenis; }
            set { jenis = value; }
        }
        public string Warna
        {
            get { return warna; }
            set { warna = value; }
        }
        public int Umur_bulan
        {
            get { return umur_bulan; }
            set { umur_bulan = value; }
        }
        public int Stok
        {
            get { return stok; }
            private set { stok = value; }
        }
        public string Deskripsi
        {
            get { return deskripsi; }
            set { deskripsi = value; }
        }
        public Boolean Is_active
        {
            get { return is_active; }
            private set { is_active = value; }
        }
        public Ikan(int id_ikan, string jenis, string warna, int umur_bulan, int stok, string deskripsi, Boolean is_active)
        {
            this.Id_ikan = id_ikan;
            this.Jenis = jenis;
            this.Warna = warna;
            this.Umur_bulan = umur_bulan;
            this.Stok = stok;
            this.Deskripsi = deskripsi;
            this.Is_active = is_active;
        }
    }
}
