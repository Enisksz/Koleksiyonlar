
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<T> class
            //T-> object türündedir.


            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);


            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count-listedeki eleman sayısını verir.
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));


            //Liste içerisinde arama
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu");
            }
            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);
            //Listeyi nasıl temizlerim
            hayvanlarListesi.Clear();

            //List içerisinde nesne tutmak
            List<kullanicilar> kullaniciListesi = new List<kullanicilar>();

            kullanicilar kullanici1= new kullanicilar();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "Nar";
            kullanici1.Yas = 19;

            kullanicilar kullanici2 = new kullanicilar();
            kullanici2.Isim = "Enis";
            kullanici2.Soyisim = "Öksüz";
            kullanici2.Yas = 22;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);


            List<kullanicilar> yeniList= new List<kullanicilar>();

            yeniList.Add(new kullanicilar()
            {
                Isim ="Deniz",
                Soyisim="Men",
                Yas=20
            });

        }
    }
    public class kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get=> isim; set=> isim=value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
