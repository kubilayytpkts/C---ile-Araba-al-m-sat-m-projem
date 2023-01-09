using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            araba a1 = new araba();

            a1.bilgiler();
        
            Console.WriteLine("Teklif Vermek ister misiniz ? E/H");
           
            String kullanıcıEH = Console.ReadLine();
            Console.Clear();

            int kullanıcıteklif;
            int genelfiyat = 0; 
           

            do
            {
                Console.Write("Lütfen Vermek istediğiniz indirim teklifini giriniz :");
               

                kullanıcıteklif = int.Parse(Console.ReadLine());
                if(kullanıcıteklif<a1.MAXindirim)
                {
                    Console.Clear();
                    System.Threading.Thread.Sleep(500);

                    Console.WriteLine("Sayın Müşterimiz vermiş olduğunuz teklif Tarafımızca kabul edilmiştir...");
                    genelfiyat =a1.SatışFiyatı-kullanıcıteklif;
                    Console.WriteLine("{0} TL ile Aracınızı indirimli bir şekilde alabilirsiniz Lütfen en yakın Bayimiz İle İletişime geçiniz Saygılar...",genelfiyat);
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sayın Müşterimiz girmiş olduğunuz Fiyat Kabul edilememiştir lütfen tekrar Fiyat veriniz");
                    
                    
                }
                Console.ReadLine();
                

            } while (kullanıcıEH != "E");
            
        }
    }
}
