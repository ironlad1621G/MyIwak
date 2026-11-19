using System;
using System.Collections.Generic;
using System.Text;

namespace MyMyIwak.Models
{
    public class Ikan
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
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Jenis ikan tidak boleh kosong");
                }
                else
                {
                    jenis = value;
                }
            }
        }
        public string Warna
        {
            get { return warna; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Warna ikan tidak boleh kosong");
                }
                else
                {
                    warna = value;
                }
            }
        }
        public int Umur_bulan
        {
            get { return umur_bulan; }
            set
            {
                if (value >= 0)
                {
                    umur_bulan = value;
                }
                else
                {
                    throw new ArgumentException("Umur tidak mungkin kurang dari 0");
                }
            }
        }
        public int Stok
        {
            get { return stok; }
            private set
            {
                if (value >= 0)
                {
                    stok = value;
                }
                else
                {
                    throw new ArgumentException("Stok tidak boleh kurang dari 0");
                }
            }
            
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
        public void TambahStok(int jumlah)
        {
            if (jumlah > 0)
            {
                Stok += jumlah;
            }
            else
            {
                throw new ArgumentException("Jumlah yang ditambahkan harus lebih besar dari 0");
            }
        }
        public void KurangiStok(int jumlah)
        {
            if (jumlah > 0)
            {
                if (Stok - jumlah >= 0)
                {
                    Stok -= jumlah;
                }
                else
                {
                    throw new ArgumentException("Stok tidak boleh kurang dari 0");
                }
            }
            else
            {
                throw new ArgumentException("Jumlah yang dikurangi harus lebih besar dari 0");
            }
        }
        public void Nonaktifkan()
        {
            if (!Is_active)
            {
                throw new InvalidOperationException("Ikan ini sudah dihapus.");
            }
            Is_active = false;
        }
    }
}
