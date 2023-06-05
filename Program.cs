using System;
using static prak8.barang;


namespace prak8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            barang orang01 = new barang();
            barang orang02 = new barang("Cocacola", 9000);
            dataBrg data_barang1 = new dataBrg("Sprite", 8000);

            orang01.InfoBarang();
            orang02.InfoBarang();

            data_barang1.InfoBarang();
            data_barang1.InfoBarang("Minuman", "CC0122");

            Console.ReadKey();
        }
    }
}