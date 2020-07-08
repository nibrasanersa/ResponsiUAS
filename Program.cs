using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "--- Responsi UAS Pemrograman ---";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }
        static void TampilMenu()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("--- Pilihan Menu ---");
            Console.WriteLine();
            Console.WriteLine("1). Tambah Produk");
            Console.WriteLine("2). Hapus Produk");
            Console.WriteLine("3). Tampilkan Produk");
            Console.WriteLine("4). Keluar Aplikasi");
        }

        static void TambahProduk()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection
            Console.WriteLine();
            Console.WriteLine("--- Tambah Data Produk ---\n");
            Produk produk = new Produk();
            Console.Write("Kode Produk : ");
            produk.kode_produk = Console.ReadLine();
            Console.Write("Nama Produk : ");
            produk.nama_produk = Console.ReadLine();
            Console.Write("Harga Beli  : ");
            produk.harga_beli = Convert.ToDouble(Console.ReadLine());
            Console.Write("Harga Jual  : ");
            produk.harga_jual = Convert.ToDouble(Console.ReadLine());
            daftarProduk.Add(produk);
            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection

            int no = -1, hapus = -1;
            Console.WriteLine("--- Hapus Data Produk ---\n");
            Console.Write("Kode Produk : ");
            string kd = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                no++;
                if (produk.kode_produk == kd)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("\nData Produk Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nKode Produk tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection

            int noUrut = 0;
            Console.WriteLine("Data Produk\n");
            foreach (Produk produk in daftarProduk)
            {
                noUrut++;
                Console.WriteLine("{0}. {1}, {2}, {3:N0}, {4:N0}", noUrut, produk.kode_produk, produk.nama_produk, produk.harga_beli, produk.harga_jual);
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
