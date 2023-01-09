using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class araba
    {
        public string marka="Audi";
        public string markaModel="H500";
        public int ModelYıl = 2000;
        public int Km=10000;
        public string yakıtTipi = "Benzinli";
        public int ArabaVitesi = 6;
        private int AlışFiyatı=8500;
        public int SatışFiyatı=15000;
        public int MAXindirim = 2500;
        public int Fiyat = 15000;

        public araba()
        {
        
        }

        public araba(string _Marka, int _ModelYıl)
        {
            marka = _Marka;
            ModelYıl = _ModelYıl;
        }

        public araba(string _Marka,string _Markamodel,int _ModelYıl)
        {
            marka =_Marka;
            markaModel = _Markamodel;
            ModelYıl = _ModelYıl;
        }

        public araba(string _Marka,string _Markamodel,int _ModelYıl,int _km)
        {
            marka = _Marka;
            markaModel = _Markamodel;
            ModelYıl = _ModelYıl;
            Km = _km;
        }


        
        public void bilgiler()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Araç Markası:{0}", marka);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Araç Modeli:{0}",markaModel);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Araç ModelYılı:{0}",ModelYıl);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Araç km'si:{0}",Km);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Araç Yakıt tipi :{0}",yakıtTipi);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Araç Vites Sayısı:{0}",ArabaVitesi);
            Console.WriteLine("***************************");
            Console.WriteLine("Araç Satış Fiyatı:{0}",SatışFiyatı);
            Console.WriteLine("***************************");
            





        }



    }
}
