using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
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
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa");
            Console.WriteLine("3. Tampilkan Mahasiswa");
            Console.WriteLine("4. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Mahasiswa mahasiswa = new Mahasiswa();
            Console.WriteLine("Tambah Mahasiswa \n");
            Console.Write("NIM : ");
            mahasiswa.Nim = Console.ReadLine();

            Console.Write("Nama : ");
            mahasiswa.Nama = Console.ReadLine();

            Console.Write("Jenis Kelamin [L/P] : ");
            mahasiswa.JenisKelamin = Console.ReadLine();
            if (mahasiswa.JenisKelamin == "L")
            {
                mahasiswa.JenisKelamin = "Laki-Laki";
            }
            else if (mahasiswa.JenisKelamin == "P")
            {
                mahasiswa.JenisKelamin = "Perempuan";
            }
            else
            {
                mahasiswa.JenisKelamin = "Jenis Kelamin Tidak Teridentifikasi";
            }

            Console.Write("IPK : ");
            mahasiswa.Ipk = double.Parse(Console.ReadLine());

            daftarMahasiswa.Add(mahasiswa);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            int nomor = -1, hapus = -1;
            Console.WriteLine();
            Console.WriteLine("Hapus Data Mahasiswa\n");
            Console.Write("NIM : ");
            string nimMahasiswa = Console.ReadLine();
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                nomor++;
                if (mahasiswa.Nim == nimMahasiswa)
                {
                    hapus = nomor;
                }
            }
            if (hapus != -1)
            {
                daftarMahasiswa.RemoveAt(hapus);
                Console.WriteLine(" Data Mahasiswa Berhasil Dihapus ");
            }
            else
            {
                Console.WriteLine("\nNIM Tidak Ditemukan ");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            int urutan = 0;
            Console.WriteLine("Data Mahasiswa\n");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                urutan++;
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", urutan, mahasiswa.Nim, mahasiswa.Nama, mahasiswa.JenisKelamin, mahasiswa.Ipk);
            }
            if (urutan < 1)
            {
                Console.WriteLine("\nData Mahasiswa Tidak Ada \n");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
