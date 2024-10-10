using System;

namespace ogrenciBilgileri_Hw2
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private double vize1;
        private double vize2;
        private double final;
        private string okulIsmi;

        public Ogrenci(int ogrenciNo, string isim, string soyisim, double vize1, double vize2, double final, string okulIsmi)
        {
            this.ogrenciNo = ogrenciNo;
            this.isim = isim;
            this.soyisim = soyisim;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
            this.okulIsmi = okulIsmi;
        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci Bilgileri:");
            Console.WriteLine($"Öğrenci No: {ogrenciNo}");
            Console.WriteLine($"İsim: {isim}");
            Console.WriteLine($"Soyisim: {soyisim}");
            Console.WriteLine($"Vize 1: {vize1}");
            Console.WriteLine($"Vize 2: {vize2}");
            Console.WriteLine($"Final: {final}");
            Console.WriteLine($"Okul İsmi: {okulIsmi}");
        }

        public void ogrenciOrtalamasiBul()
        {
            double ortalama = (vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4);
            Console.WriteLine($"Öğrencinin Ortalaması: {ortalama:F2}");
        }

        public void okulGetir()
        {
            Console.WriteLine($"Okul İsmi: {okulIsmi}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci(12345, "Ahmet", "Yılmaz", 85, 90, 80, "Ankara Üniversitesi");

            bool cikisYapildi = false;

            while (!cikisYapildi)
            {
                Console.WriteLine("\nLütfen bir işlem seçiniz:");
                Console.WriteLine("1- Öğrenci Bilgilerini Göster");
                Console.WriteLine("2- Öğrenci Ortalamasını Göster");
                Console.WriteLine("3- Okul İsmini Göster");
                Console.WriteLine("4- Çıkış");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogrenci.ogrenciBilgileriGoster();
                        break;
                    case "2":
                        ogrenci.ogrenciOrtalamasiBul();
                        break;
                    case "3":
                        ogrenci.okulGetir();
                        break;
                    case "4":
                        cikisYapildi = true;
                        Console.WriteLine("Çıkış yapıldı.");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
}
