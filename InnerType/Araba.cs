﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class Araba
    {
        public string Marka;
        public string Model;
        public void InfoShow()
        {
            Marka = "Lamborghini";
            Model = "Aventador";
            Console.WriteLine("Arabanın Markası:"+Marka);
            Console.WriteLine("Arabanın Modeli:" +Model);
        }

        public class ArabaIcDonanim //innertype
        {
            public string direksiyon;
            public string viteskolu;
            public void IcBilgi()
            {
                direksiyon = "Elektrikli Direksiyon";
                viteskolu = "Tam Otomatik";
                Console.WriteLine("Direksiyon Türü:"+direksiyon);
                Console.WriteLine("Vites Kolu :" + viteskolu);

            }
        }
    }
}
