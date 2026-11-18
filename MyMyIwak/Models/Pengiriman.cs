namespace MyMyIwak.Models
{
    public class Pengiriman
    {
        private readonly int id_pengiriman;
        private readonly int id_transaksi;
        private readonly int id_layanan;
        private readonly string nama_penerima;
        private readonly string no_telepon;
        private readonly string alamat_tujuan;
        private readonly long ongkir;

        private StatusPengiriman status;
        private DateTime? waktu_kirim;
        private DateTime? waktu_diterima;

        public Pengiriman(int id_pengiriman, int id_transaksi, int id_layanan,
                          string nama_penerima, string no_telepon, string alamat_tujuan, long ongkir,
                          StatusPengiriman status = StatusPengiriman.Menunggu,
                          DateTime? waktu_kirim = null, DateTime? waktu_diterima = null)
        {
            if (string.IsNullOrWhiteSpace(nama_penerima))
            {
                throw new ArgumentException("Nama penerima wajib diisi.");
            }
            if (string.IsNullOrWhiteSpace(no_telepon))
            {
                throw new ArgumentException("Nomor telepon wajib diisi.");
            }
            if (string.IsNullOrWhiteSpace(alamat_tujuan))
            {
                throw new ArgumentException("Alamat tujuan wajib diisi.");
            }
            if (ongkir < 0)
            {
                throw new ArgumentException("Ongkir tidak boleh negatif.");
            }

            this.id_pengiriman = id_pengiriman;
            this.id_transaksi = id_transaksi;
            this.id_layanan = id_layanan;
            this.nama_penerima = nama_penerima;
            this.no_telepon = no_telepon;
            this.alamat_tujuan = alamat_tujuan;
            this.ongkir = ongkir;
            this.status = status;
            this.waktu_kirim = waktu_kirim;
            this.waktu_diterima = waktu_diterima;
        }

        public int IdPengiriman => id_pengiriman;
        public int IdTransaksi => id_transaksi;
        public int IdLayanan => id_layanan;
        public string NamaPenerima => nama_penerima;
        public string NoTelepon => no_telepon;
        public string AlamatTujuan => alamat_tujuan;
        public long Ongkir => ongkir;
        public StatusPengiriman Status => status;
        public DateTime? WaktuKirim => waktu_kirim;
        public DateTime? WaktuDiterima => waktu_diterima;


        public void Kemas()
        {
            if (status != StatusPengiriman.Menunggu)
            {
                throw new InvalidOperationException("Hanya pesanan yang menunggu yang bisa dikemas.");
            }
            status = StatusPengiriman.Dikemas;
        }

        public void Kirim(DateTime sekarang)
        {
            if (status != StatusPengiriman.Dikemas)          
            {
                throw new InvalidOperationException("Pesanan harus dikemas dulu.");
            }
            status = StatusPengiriman.Dikirim;               
            waktu_kirim = sekarang;                          
        }


        public void KonfirmasiDiterima(DateTime sekarang)
        {
            if (status != StatusPengiriman.Dikirim)
            {
                throw new InvalidOperationException("Pesanan belum dikirim.");
            }
            status = StatusPengiriman.Diterima;
            waktu_diterima = sekarang;
        }

        public void Batalkan()
        {
            if (status != StatusPengiriman.Menunggu)
            {
                throw new InvalidOperationException("Pesanan yang sudah diproses tidak bisa dibatalkan.");
            }
            status = StatusPengiriman.Dibatalkan;
        }
    }
}