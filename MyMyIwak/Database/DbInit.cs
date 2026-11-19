using System;
using Npgsql;

namespace MyMyIwak.Database
{
    internal class DatabaseInitializer
    {
        private readonly DbConn db = new DbConn();

        public void CreateTables()
        {
            using (NpgsqlConnection conn = db.GetConnection())
            {
                conn.Open();

                using (NpgsqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string[] queries =
                        {
                            // 1. TABEL AKUN
                            @"
                            CREATE TABLE IF NOT EXISTS akun (
                                id_akun SERIAL PRIMARY KEY,
                                username VARCHAR(50) NOT NULL UNIQUE,
                                nama_lengkap VARCHAR(100) NOT NULL,
                                password VARCHAR(255) NOT NULL,
                                no_telepon VARCHAR(20),
                                alamat VARCHAR(255),
                                role VARCHAR(30) NOT NULL,
                                is_active BOOLEAN DEFAULT TRUE
                            );
                            ",

                            // 2. TABEL IKAN
                            @"
                            CREATE TABLE IF NOT EXISTS ikan (
                                id_ikan SERIAL PRIMARY KEY,
                                jenis VARCHAR(100) NOT NULL,
                                warna VARCHAR(50) NOT NULL,
                                umur_bulan INTEGER NOT NULL
                                    CHECK (umur_bulan >= 0),
                                stok INTEGER NOT NULL DEFAULT 0
                                    CHECK (stok >= 0),
                                harga BIGINT NOT NULL
                                    CHECK (harga >= 0),
                                deskripsi TEXT,
                                is_active BOOLEAN DEFAULT TRUE
                            );
                            ",

                            // 3. TABEL LAYANAN PENGIRIMAN
                            @"
                            CREATE TABLE IF NOT EXISTS layanan_pengiriman (
                                id_layanan SERIAL PRIMARY KEY,
                                nama_layanan VARCHAR(30) NOT NULL,
                                ongkir BIGINT NOT NULL
                                    CHECK (ongkir >= 0),
                                estimasi VARCHAR(50)
                            );
                            ",

                            // 4. TABEL FOTO IKAN
                            @"
                            CREATE TABLE IF NOT EXISTS foto_ikan (
                                id_foto_ikan SERIAL PRIMARY KEY,
                                id_ikan INTEGER NOT NULL,
                                gambar VARCHAR(255),

                                CONSTRAINT fk_foto_ikan
                                    FOREIGN KEY (id_ikan)
                                    REFERENCES ikan(id_ikan)
                                    ON DELETE CASCADE
                            );
                            ",

                            // 5. TABEL KERANJANG
                            @"
                            CREATE TABLE IF NOT EXISTS keranjang (
                                id_keranjang SERIAL PRIMARY KEY,
                                id_akun INTEGER NOT NULL,
                                id_ikan INTEGER NOT NULL,
                                jumlah INTEGER NOT NULL
                                    CHECK (jumlah > 0),

                                CONSTRAINT fk_keranjang_akun
                                    FOREIGN KEY (id_akun)
                                    REFERENCES akun(id_akun)
                                    ON DELETE CASCADE,

                                CONSTRAINT fk_keranjang_ikan
                                    FOREIGN KEY (id_ikan)
                                    REFERENCES ikan(id_ikan)
                                    ON DELETE CASCADE
                            );
                            ",

                            // 6. TABEL KOMENTAR
                            @"
                            CREATE TABLE IF NOT EXISTS komentar (
                                id_komentar SERIAL PRIMARY KEY,
                                id_akun INTEGER NOT NULL,
                                id_ikan INTEGER NOT NULL,
                                komentar TEXT NOT NULL,
                                waktu_komentar TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                is_active BOOLEAN DEFAULT TRUE,

                                CONSTRAINT fk_komentar_akun
                                    FOREIGN KEY (id_akun)
                                    REFERENCES akun(id_akun),

                                CONSTRAINT fk_komentar_ikan
                                    FOREIGN KEY (id_ikan)
                                    REFERENCES ikan(id_ikan)
                            );
                            ",

                            // 7. TABEL TRANSAKSI
                            @"
                            CREATE TABLE IF NOT EXISTS transaksi (
                                id_transaksi SERIAL PRIMARY KEY,
                                id_akun INTEGER NOT NULL,
                                tanggal TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                metode_pembayaran VARCHAR(30) NOT NULL,
                                status_pembayaran VARCHAR(30) NOT NULL,
                                total_bayar BIGINT NOT NULL
                                    CHECK (total_bayar >= 0),

                                CONSTRAINT fk_transaksi_akun
                                    FOREIGN KEY (id_akun)
                                    REFERENCES akun(id_akun)
                            );
                            ",

                            // 8. TABEL DETAIL TRANSAKSI
                            @"
                            CREATE TABLE IF NOT EXISTS detail_transaksi (
                                id_detail_transaksi SERIAL PRIMARY KEY,
                                id_transaksi INTEGER NOT NULL,
                                id_ikan INTEGER NOT NULL,
                                jumlah INTEGER NOT NULL
                                    CHECK (jumlah > 0),

                                CONSTRAINT fk_detail_transaksi
                                    FOREIGN KEY (id_transaksi)
                                    REFERENCES transaksi(id_transaksi)
                                    ON DELETE CASCADE,

                                CONSTRAINT fk_detail_ikan
                                    FOREIGN KEY (id_ikan)
                                    REFERENCES ikan(id_ikan)
                            );
                            ",

                            // 9. TABEL FAKTUR
                            @"
                            CREATE TABLE IF NOT EXISTS faktur (
                                id_faktur SERIAL PRIMARY KEY,
                                id_transaksi INTEGER NOT NULL,
                                nomor_faktur VARCHAR(30) NOT NULL UNIQUE,
                                tanggal_terbit TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

                                CONSTRAINT fk_faktur_transaksi
                                    FOREIGN KEY (id_transaksi)
                                    REFERENCES transaksi(id_transaksi)
                                    ON DELETE CASCADE
                            );
                            ",

                            // 10. TABEL PENGIRIMAN
                            @"
                            CREATE TABLE IF NOT EXISTS pengiriman (
                                id_pengiriman SERIAL PRIMARY KEY,
                                id_transaksi INTEGER NOT NULL,
                                id_layanan INTEGER NOT NULL,
                                nama_penerima VARCHAR(100) NOT NULL,
                                no_telepon VARCHAR(20) NOT NULL,
                                alamat_tujuan VARCHAR(255) NOT NULL,
                                ongkir BIGINT NOT NULL
                                    CHECK (ongkir >= 0),
                                status VARCHAR(30) NOT NULL,
                                waktu_kirim TIMESTAMP,

                                CONSTRAINT fk_pengiriman_transaksi
                                    FOREIGN KEY (id_transaksi)
                                    REFERENCES transaksi(id_transaksi)
                                    ON DELETE CASCADE,

                                CONSTRAINT fk_pengiriman_layanan
                                    FOREIGN KEY (id_layanan)
                                    REFERENCES layanan_pengiriman(id_layanan)
                            );
                            "
                        };

                        foreach (string query in queries)
                        {
                            using (NpgsqlCommand cmd =
                                new NpgsqlCommand(query, conn, transaction))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        Console.WriteLine(
                            "Seluruh tabel MyIwak berhasil dibuat!"
                        );
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
