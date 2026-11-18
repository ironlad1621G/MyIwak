namespace MyMyIwak.Models
{
    public class Transaksi
    {
        private int id_transaksi;
        private int id_akun;
        private DateTime tanggal;
        private MetodePembayaran metodePembayaran;
        private StatusPembayaran statusPembayaran;
        private long totalPembayaran;
        
        public Transaksi(int id_transaksi, int id_akun, DateTime tanggal, MetodePembayaran metodePembayaran, StatusPembayaran statusPembayaran, long totalPembayaran)
        {
            this.id_transaksi = id_transaksi;
            this.id_akun = id_akun;
            this.tanggal = tanggal;
            this.metodePembayaran = metodePembayaran;
            this.statusPembayaran = statusPembayaran;
            this.totalPembayaran = totalPembayaran;
        }

        public int IdTransaksi => id_transaksi;
        public int IdAkun => id_akun;
        public DateTime Tanggal => tanggal;
        public MetodePembayaran MetodePembayaran => metodePembayaran;
        public StatusPembayaran StatusPembayaran => statusPembayaran;
        public long TotalPembayaran => totalPembayaran;

        private readonly List<Detailtransaksi> detail = new();

        public IReadOnlyList<Detailtransaksi> Detail => detail;

        public void TambahDetail(Detailtransaksi d)
        {
            if (d == null)
            {
                throw new ArgumentNullException(nameof(d));
            }
            detail.Add(d);
        }

        public long HitungSubtotal()
        {
            long total = 0;
            foreach (var d in detail)
            {
                total += d.HitungSubTotal();
            }
            return total;
        }


        public static readonly TimeSpan BatasPembayaran = TimeSpan.FromHours(24);

        public DateTime BatasBayar => tanggal + BatasPembayaran;

        public bool Kadaluarsa(DateTime sekarang)
        {
            return statusPembayaran == StatusPembayaran.Menunggu && sekarang > BatasBayar;
        }

        public void Lunasi(DateTime sekarang)
        {
            if (statusPembayaran != StatusPembayaran.Menunggu)
            {
                throw new InvalidOperationException("Hanya transaksi yang menunggu pembayaran yang bisa divalidasi.");
            }

            if (Kadaluarsa(sekarang))
            {
                throw new InvalidOperationException("Batas waktu pembayaran 1x24 jam sudah lewat.");
            }

            statusPembayaran = StatusPembayaran.Lunas;
        }

        public void Tolak()
        {
            if (statusPembayaran != StatusPembayaran.Menunggu)
            {
                throw new InvalidOperationException("Transaksi ini sudah diproses sebelumnya.");
            }

            statusPembayaran = StatusPembayaran.Ditolak;
        }
    }
 }
