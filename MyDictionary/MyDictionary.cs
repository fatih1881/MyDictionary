using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T> // aşağıdaki items kafanı karıstırmasın. Oraya elemanda yazabilirsin o ingilizcesi :) 
    {
        T[] items; // Bu soldaki T items arrayi yani dizisi. İtem dizisi oluşturdum.  Fakat dizilerin her zaman değerini vermem lazım yoksa hata alırım. 0 bile olsa belirtmem gerek. Şimdi onu yapacağıoz
        
        // Burada aşağıda oluşturduuğum const. Fakettiysen düz public var sadece normalde public void falan eklerdik yanına fakat yok. Bu cont. Bir array sıfırlayacak orası const olur.

        public MyDictionary()
        {
            items = new T[0]; // Bak yukarda oluşturduuğum arrayi burada sıfırladım. Burası const oluyor işte :) Yani sıfır elemanlı bir dizi yaptım.

                
        }
       
        public void Add(T item)

            
        {
            T[] gecicidizi = items; // Önce aşağıdaki koda bak sonra  koda bak // Yani elemanlar gitmesin diye gecici diziye tutturduk.

            items = new T[items.Length + 1]; //Burada dizimizi bir arttırdık. Yani eleman sayımız sıfırdı şidm sürekli bir arttıracak. Örneği Duygu girceksin bir elemean daha isticek sonra birini daha girceksin 1 arttırcak bir tane daha eleman isticek.

            // Ama unutma ki biz burda new kullanıyoruuz. New kullandıkça eski elemanlar kayboluyor . Biz eski elemanları tutmak istiyoruz onun için gecici dizi olusturcaz.

            for (int i = 0; i < gecicidizi.Length; i++)
            {
                items[i] = gecicidizi[i];
            }
            // bu for döngüsünü kullanarak o geçiçi dizideki elemanları tekrar bize dönmesini sağladık.
            items[items.Length - 1] = item;// bunu videodan anlarsın        
        }
       


    }
}
