using Entities.Concrete;
using System;


namespace Workaround 
{
    class Program 
    {

        static void Main(string[] args) { 
            Person person = new Person();

            SelamVer("Eren");

            int toplam = Topla(2, 5);
        }

        static void SelamVer(string isim = "Nameless") {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 0, int sayi2 = 0) {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            
            return sonuc;
        }
    }

    public class Vatandas {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long tcNo { get; set; }
    }
}