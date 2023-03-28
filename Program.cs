using System;

namespace Praktikum3
{
    public class MobilApp
    {
        static public void Main(String[] args)
        {
            Mobil mobil1 = new Mobil();
            mobil1.warna = "Blue";
            mobil1.JumlahPintu = 2;
            mobil1.merek = "GTR";
            mobil1.model = "Super Car";
            mobil1.TahunKeluar = 2018;

            mobil1.Gas(500);
            mobil1.Klakson("Ngook Ngook");
            mobil1.TampilkanInfo();

            Console.WriteLine("\n");
            Console.WriteLine("===================");

            Mobil mobil2 = new Mobil();
            mobil2.warna = "Green";
            mobil2.JumlahPintu = 2;
            mobil2.merek = "Bugati";
            mobil2.model = "Hyper Car";
            mobil2.TahunKeluar = 2020;

            mobil2.Gas(800);
            mobil2.Klakson("Ngkerr Ngkerr");
            mobil2.TampilkanInfo();

            Console.ReadKey();
        }
	}
}
