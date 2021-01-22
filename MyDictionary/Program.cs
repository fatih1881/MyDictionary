using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler= new MyDictionary<string>();
            isimler.Add("Duygu");

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count); // şurdaki liste.count dizide kaç eleman varsa o kadar sayı yazdırır senin için hocada olmayan bir örneği yapıcam

            List<int> sayılar = new List<int>();
            sayılar.Add(1);
            sayılar.Add(2);
            Console.WriteLine(sayılar.Count); // bak mesela burda kaç tane sayı var ? Yani kaç sayı eklemişim 1 rakamını ve 2 rakamını eklemişim. Kaç elemanım var yani iki elemanım var :) çalıştırdığğında 2 sayısını göreceksin.
        }
       
            
    }
}
