using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpOdevTaha
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream dosya = new FileStream(@"D:\TAHABABAYEV\NTPOdev\NTPOdev.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter yazdır = new StreamWriter(dosya);
            Console.Write("Kaç Araç Tanımlayacaksınız:");
            int sayi = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                Tasit tasit = new Tasit();
                Araba araba = new Araba();

                Console.Write(i + "." + "Araç markasını giriniz:");
                tasit.Marka = Console.ReadLine();
                Console.Write(i + "." + "Araç modelini giriniz:");
                tasit.Model = Console.ReadLine();
                Console.Write(i + "." + "Araç rengini giriniz:");
                tasit.Renk = Console.ReadLine();
                Console.Write(i + "." + "Araç çekiş türünü giriniz:");
                araba.cekisturu = Console.ReadLine();
                Console.Write(i+"."+"Araç opsiyonlarını giriniz:");
                araba.opsiyonlar = Console.ReadLine();
                yazdır.WriteLine(i+"."+"Araç Markası:{0}, Araç Modeli:{1} Araç Rengi:{2} Aracın Çekiş Türü:{3} Aracın Opsiyonları:{4}" ,tasit.Marka,tasit.Model,tasit.Renk,araba.cekisturu,araba.opsiyonlar);
                Console.Clear();

            }
            yazdır.Close();
            Console.WriteLine("Araçlar Kaydedildi.");
            Console.ReadKey();
        }
    }
}
