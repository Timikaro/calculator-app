using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication1
{
    class Program

    {

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static void Menu(int pilih_menu)
        {
            switch (pilih_menu)
            {
                case 1:
                    Console.WriteLine(pilih_menu + " Penambahan");
                    break;
                case 2:
                    Console.WriteLine(pilih_menu + " Pengurangan");
                    break;
                case 3:
                    Console.WriteLine(pilih_menu + " Perkalian");
                    break;
                case 4:
                    Console.WriteLine(pilih_menu + " Pembagian");
                    break;
            }
                
            
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static float Pembagian(float a, float b)
        {
            return a / b;
        }
     


        static void Main(string[] args)
        {
            Menu:
            Console.Title = "Kalkulator";
            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Masukan Nomor Menu[1...4]:");
            int pilihan_menu = int.Parse(Console.ReadLine());


            if (pilihan_menu == 1)
            {
            penambahan:
                Console.Clear();
                Menu(pilihan_menu);
                Console.Write("Masukan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                Console.WriteLine("1. Ulangi?");
                Console.WriteLine("2. Kembali ke menu utama?");
                Console.WriteLine("3. Keluar Program");
                Console.Write("Pilihan( inputkan dalam bentuk angka ) = ");
                string ulang = Console.ReadLine();
                if (ulang == "1")
                {
                    Console.Clear();
                    goto penambahan;
                }
                else if (ulang == "2")
                {
                    Console.Clear();
                    goto Menu;
                }
                else
                {
                    goto exit;
                }

            }
            else if (pilihan_menu == 2)
            {
            pengurangan:
                Console.Clear();
                Menu(pilihan_menu);
                Console.Write("Masukan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
                Console.WriteLine("1. Ulangi?");
                Console.WriteLine("2. Kembali ke menu utama?");
                Console.WriteLine("3. Keluar Program");
                Console.Write("Pilihan( inputkan dalam bentuk angka ) = ");
                string ulang = Console.ReadLine();
                if (ulang == "1")
                {
                    Console.Clear();
                    goto pengurangan;
                }
                else if (ulang == "2")
                {
                    Console.Clear();
                    goto Menu;
                }
                else
                {
                    goto exit;
                }
            }
            else if (pilihan_menu == 3)
            {
            perkalian:
                Console.Clear();
                Menu(pilihan_menu);
                Console.Write("Masukan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
                Console.WriteLine("1. Ulangi?");
                Console.WriteLine("2. Kembali ke menu utama?");
                Console.WriteLine("3. Keluar Program");
                Console.Write("Pilihan( inputkan dalam bentuk angka ) = ");
                string ulang = Console.ReadLine();
                if (ulang == "1")
                {
                    Console.Clear();
                    goto perkalian;
                }
                else if (ulang == "2")
                {
                    Console.Clear();
                    goto Menu;
                }
                else
                {
                    goto exit;
                }
            }
            else if (pilihan_menu == 4)
            {
                pembagian:
                Console.Clear();
                Menu(pilihan_menu);
                Console.Write("Masukan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + Pembagian(a, b));
                Console.WriteLine("1. Ulangi?");
                Console.WriteLine("2. Kembali ke menu utama?");
                Console.WriteLine("3. Keluar Program");
                Console.Write("Pilihan( inputkan dalam bentuk angka ) = ");
                string ulang = Console.ReadLine();
                if (ulang == "1")
                {
                    Console.Clear();
                    goto pembagian;
                }
                else if (ulang == "2")
                {
                    Console.Clear();
                    goto Menu;
                }
                else
                {
                    goto exit;
                }
            }
            else
            {
                Console.Write("Maaf, menu yang Anda pilih tidak tersedia");
            }
            exit:
            Console.WriteLine("\n Tekan sembarang untuk keluar");
            Console.ReadKey();
        }
    }

}
