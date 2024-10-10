using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Lütfen TC Kimlik Numaranızı giriniz: ");
                string tcKimlikNo = Console.ReadLine();

                Personel personel = new Personel(tcKimlikNo);

                Console.WriteLine("TC Kimlik No (ilk 5 karakter): " + personel.GetTcKimlikNoIlk5Karakter());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            Console.ReadLine();
        }
    }

    public class Personel
    {
        private string tcKimlikNo;

        public Personel(string tcKimlikNo)
        {
            if (tcKimlikNo.Length == 11 && long.TryParse(tcKimlikNo, out _))
            {
                this.tcKimlikNo = tcKimlikNo;
            }
            else
            {
                throw new Exception("Tc Kimlik No 11 haneli ve sadece sayılardan oluşmalıdır.");
            }
        }

        public string GetTcKimlikNoIlk5Karakter()
        {
            return tcKimlikNo.Substring(0, 5);
        }
    }
}
