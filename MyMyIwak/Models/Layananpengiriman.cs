namespace MyMyIwak.Models
{
    public class Layananpengiriman
    {
        private int id_layanan;
        private string nama_layanan;
        private long ongkir;
        private string estimasi;

        public Layananpengiriman(int id_layanan, string nama_layanan, long ongkir, string estimasi)
        {
            if (string.IsNullOrWhiteSpace(nama_layanan))
            {
                throw new ArgumentException("Nama layanan wajib diisi.");
            }
            if (ongkir < 0)
            {
                throw new ArgumentException("Ongkir tidak boleh negatif.");
            }
            
            this.id_layanan = id_layanan;
            this.nama_layanan = nama_layanan;
            this.ongkir = ongkir;
            this.estimasi = estimasi;
        }


        public int IdLayanan => id_layanan;
        public string NamaLayanan => nama_layanan;
        public long Ongkir => ongkir;
        public string Estimasi => estimasi;


        public void UbahLayanan(long ongkir_baru, string estimasi_baru)
        {
            if (ongkir_baru < 0)
            {
                throw new ArgumentException("Ongkir tidak boleh negatif.");
            }
            ongkir = ongkir_baru;
            estimasi = estimasi_baru;

        }
    }
}