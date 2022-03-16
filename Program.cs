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
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {

            Console.Title = "Kalkulator";
            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Masukan Nomor Menu[1...4]:");
            int pilih_menu = int.Parse(Console.ReadLine());


            if (pilih_menu == 1)
            {
                Console.Clear();
                Menu(pilih_menu);
                Console.Write("Masukan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                
            }
            else if (pilih_menu == 2)
            {
                Console.Clear();
                Menu(pilih_menu);
                Console.Write("Masukan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Hasil Penambahan " + a + " - " + b + " = " + Pengurangan(a, b));
            }
            else if (pilih_menu == 3)
            {
                Console.Clear();
                Menu(pilih_menu);
                Console.Write("Masukan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasil Penambahan " + a + " * " + b + " = " + Perkalian(a, b));
            }
            else if (pilih_menu == 4)
            {
                Console.Clear();
                Menu(pilih_menu);
                Console.Write("Masukan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Hasil Penambahan " + a + " / " + b + " = " + Pembagian(a, b));
            }
            else
            {
                Console.Write("Maaf, menu yang Anda pilih tidak tersedia");
            }

            Console.WriteLine("\n Tekan sembarang untuk keluar");
            Console.ReadKey();
        }
    }
}
