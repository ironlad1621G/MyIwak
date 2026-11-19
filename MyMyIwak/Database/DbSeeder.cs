
using System;
using Npgsql;

namespace MyMyIwak.Database
{
    public static class DbSeeder
    {
        public static void Seed()
        {
            using (NpgsqlConnection conn = new DbConn().GetConnection())
            {
                conn.Open();

                using (NpgsqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        Execute(conn, transaction, @"
                            INSERT INTO akun
                            (id_akun, username, nama_lengkap, password,
                             no_telepon, alamat, role, is_active)
                            VALUES
                            (1, 'admin', 'Endministrator', 'admin123', '081234567801', 'Jember', 'admin', TRUE),
                            (2, 'user01', 'Andi Pratama', 'user123', '081234567802', 'Jember', 'user', TRUE),
                            (3, 'user02', 'Budi Santoso', 'user123', '081234567803', 'Bondowoso', 'user', TRUE),
                            (4, 'user03', 'Citra Lestari', 'user123', '081234567804', 'Banyuwangi', 'user', TRUE),
                            (5, 'user04', 'Dewi Anggraini', 'user123', '081234567805', 'Lumajang', 'user', TRUE)
                            ON CONFLICT (id_akun) DO NOTHING;
                        ");

                        Execute(conn, transaction, @"
                            INSERT INTO ikan
                            (id_ikan, jenis, warna, umur_bulan,
                             stok, harga, deskripsi, is_active)
                            VALUES
                            (1, 'Cupang Halfmoon', 'Merah', 5, 10, 50000, 'Cupang dengan sirip setengah lingkaran', TRUE),
                            (2, 'Cupang Crowntail', 'Biru', 4, 8, 45000, 'Cupang dengan sirip menyerupai mahkota', TRUE),
                            (3, 'Guppy', 'Kuning', 3, 15, 15000, 'Ikan guppy hias berwarna cerah', TRUE),
                            (4, 'Koi Kohaku', 'Merah Putih', 12, 5, 150000, 'Ikan koi dengan pola merah putih', TRUE),
                            (5, 'Louhan', 'Merah', 8, 4, 250000, 'Ikan louhan dengan jenong menonjol', TRUE)
                            ON CONFLICT (id_ikan) DO NOTHING;
                        ");

                        Execute(conn, transaction, @"
                            INSERT INTO layanan_pengiriman
                            (id_layanan, nama_layanan, ongkir, estimasi)
                            VALUES
                            (1, 'Reguler', 10000, '2-4 hari'),
                            (2, 'Express', 20000, '1-2 hari'),
                            (3, 'Same Day', 30000, 'Hari yang sama'),
                            (4, 'Kargo', 15000, '3-5 hari'),
                            (5, 'Instant', 40000, 'Beberapa jam')
                            ON CONFLICT (id_layanan) DO NOTHING;
                        ");

                        Execute(conn, transaction, @"
                            INSERT INTO foto_ikan
                            (id_foto_ikan, id_ikan, gambar)
                            VALUES
                            (1, 1, 'cupang_halfmoon.jpg'),
                            (2, 2, 'cupang_crowntail.jpg'),
                            (3, 3, 'guppy.jpg'),
                            (4, 4, 'koi_kohaku.jpg'),
                            (5, 5, 'louhan.jpg')
                            ON CONFLICT (id_foto_ikan) DO NOTHING;
                        ");

                        Execute(conn, transaction, @"
                            INSERT INTO keranjang
                            (id_keranjang, id_akun, id_ikan, jumlah)
                            VALUES
                            (1, 2, 1, 2),
                            (2, 2, 3, 3),
                            (3, 3, 2, 1),
                            (4, 4, 4, 2),
                            (5, 5, 5, 1)
                            ON CONFLICT (id_keranjang) DO NOTHING;
                        ");

                        Execute(conn, transaction, @"
                            INSERT INTO komentar
                            (id_komentar, id_akun, id_ikan, komentar,
                             waktu_komentar, is_active)
                            VALUES
                            (1, 2, 1, 'Warna ikan sangat bagus!', CURRENT_TIMESTAMP, TRUE),
                            (2, 3, 2, 'Siripnya terlihat unik.', CURRENT_TIMESTAMP, TRUE),
                            (3, 4, 3, 'Ikan sehat dan aktif.', CURRENT_TIMESTAMP, TRUE),
                            (4, 5, 4, 'Pola warnanya menarik.', CURRENT_TIMESTAMP, TRUE),
                            (5, 2, 5, 'Kondisi ikan sangat baik.', CURRENT_TIMESTAMP, TRUE)
                            ON CONFLICT (id_komentar) DO NOTHING;
                        ");

                        Execute(conn, transaction, @"
                            INSERT INTO transaksi
                            (id_transaksi, id_akun, tanggal,
                             metode_pembayaran, status_pembayaran, total_bayar)
                            VALUES
                            (1, 2, CURRENT_TIMESTAMP - INTERVAL '5 days', 'Transfer', 'Lunas', 110000),
                            (2, 3, CURRENT_TIMESTAMP - INTERVAL '4 days', 'E-Wallet', 'Lunas', 65000),
                            (3, 4, CURRENT_TIMESTAMP - INTERVAL '3 days', 'Transfer', 'Menunggu', 330000),
                            (4, 5, CURRENT_TIMESTAMP - INTERVAL '2 days', 'COD', 'Menunggu', 265000),
                            (5, 2, CURRENT_TIMESTAMP - INTERVAL '1 day', 'E-Wallet', 'Lunas', 100000)
                            ON CONFLICT (id_transaksi) DO NOTHING;
                        ");

                        Execute(conn, transaction, @"
                            INSERT INTO detail_transaksi
                            (id_detail_transaksi, id_transaksi, id_ikan, jumlah)
                            VALUES
                            (1, 1, 1, 2),
                            (2, 2, 2, 1),
                            (3, 3, 4, 2),
                            (4, 4, 5, 1),
                            (5, 5, 3, 4)
                            ON CONFLICT (id_detail_transaksi) DO NOTHING;
                        ");

                        Execute(conn, transaction, @"
                            INSERT INTO faktur
                            (id_faktur, id_transaksi, nomor_faktur, tanggal_terbit)
                            VALUES
                            (1, 1, 'INV-2026-001', CURRENT_TIMESTAMP),
                            (2, 2, 'INV-2026-002', CURRENT_TIMESTAMP),
                            (3, 3, 'INV-2026-003', CURRENT_TIMESTAMP),
                            (4, 4, 'INV-2026-004', CURRENT_TIMESTAMP),
                            (5, 5, 'INV-2026-005', CURRENT_TIMESTAMP)
                            ON CONFLICT (id_faktur) DO NOTHING;
                        ");

                        Execute(conn, transaction, @"
                            INSERT INTO pengiriman
                            (id_pengiriman, id_transaksi, id_layanan,
                             nama_penerima, no_telepon, alamat_tujuan,
                             ongkir, status, waktu_kirim)
                            VALUES
                            (1, 1, 1, 'Andi Pratama', '081234567802', 'Jember', 10000, 'Dikirim', CURRENT_TIMESTAMP),
                            (2, 2, 2, 'Budi Santoso', '081234567803', 'Bondowoso', 20000, 'Diproses', NULL),
                            (3, 3, 3, 'Citra Lestari', '081234567804', 'Banyuwangi', 30000, 'Menunggu', NULL),
                            (4, 4, 4, 'Dewi Anggraini', '081234567805', 'Lumajang', 15000, 'Menunggu', NULL),
                            (5, 5, 5, 'Andi Pratama', '081234567802', 'Jember', 40000, 'Dikirim', CURRENT_TIMESTAMP)
                            ON CONFLICT (id_pengiriman) DO NOTHING;
                        ");

                        var sequences = new (string Table, string Column)[]
                        {
                            ("akun", "id_akun"),
                            ("ikan", "id_ikan"),
                            ("layanan_pengiriman", "id_layanan"),
                            ("foto_ikan", "id_foto_ikan"),
                            ("keranjang", "id_keranjang"),
                            ("komentar", "id_komentar"),
                            ("transaksi", "id_transaksi"),
                            ("detail_transaksi", "id_detail_transaksi"),
                            ("faktur", "id_faktur"),
                            ("pengiriman", "id_pengiriman")
                        };

                        foreach (var item in sequences)
                        {
                            using (NpgsqlCommand cmd = new NpgsqlCommand(
                                $@"SELECT setval(
                                    pg_get_serial_sequence('{item.Table}', '{item.Column}'),
                                    COALESCE((SELECT MAX({item.Column}) FROM {item.Table}), 1),
                                    EXISTS(SELECT 1 FROM {item.Table})
                                );",
                                conn, transaction))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        Console.WriteLine("Seeder berhasil dijalankan!");
                        Console.WriteLine("10 tabel telah diisi dengan data contoh.");
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private static void Execute(
            NpgsqlConnection conn,
            NpgsqlTransaction transaction,
            string query)
        {
            using (NpgsqlCommand cmd =
                new NpgsqlCommand(query, conn, transaction))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}

