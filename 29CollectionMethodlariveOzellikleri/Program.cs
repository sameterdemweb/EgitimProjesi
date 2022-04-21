﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29CollectionMethodlariveOzellikleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MusteriDegerleri> musteriler = new List<MusteriDegerleri> //1. yöntem tanımlarken toplu eklemek
                {
                    new MusteriDegerleri{Id=1,Adi="Ferhat" },
                    new MusteriDegerleri{Id=2,Adi="Samet" },
                    new MusteriDegerleri{Id=3,Adi="Ahmet" },
                    new MusteriDegerleri{Id=4,Adi="Furkan" },
                    new MusteriDegerleri{Id=5,Adi="Mehmet" },
                    new MusteriDegerleri{Id=6,Adi="Gamze" }
                };

            MusteriDegerleri musteriDegerleri1 = new MusteriDegerleri { 
                Id=7, Adi="Ege"
            };
            

         
            musteriler.Add(musteriDegerleri1);
            musteriler.Add(new MusteriDegerleri { Id = 8, Adi = "Özge" }); // Koleksiyona yeni değer ekleme

            musteriler.AddRange(new MusteriDegerleri[2] // Yeni gelecek olan değerleri toplu şekilde ekleyebiliriz. Yeni bir listeyi toplu olarak eklenebilir.
            {
                new MusteriDegerleri{Id = 9, Adi ="Ege"},
                new MusteriDegerleri{Id = 10, Adi ="Cenk"}
            });

           


            int MusteriSayisi = musteriler.Count(); // Koleksiyonların Listelerin  değer sayısını verir.
            // musteriler.Clear(); // Listeyi Temizler
      

            Console.WriteLine("Toplam Müşteri Sayısı : {0}",MusteriSayisi);

            bool icindeVarmi = musteriler.Contains(musteriDegerleri1);  // Contains tanımlanan nesne yada değerin bu listede aradığımız değer varmı diye arama yapar. Bool tipinde true yada false olarak değer döndürür.
            Console.WriteLine("Liste içinde değer var mı diye bakıldı '{0}' sonucu döndürüldü.", icindeVarmi);
            
            
            bool icindeVarmi2 = musteriler.Contains(new MusteriDegerleri { Id = 8, Adi = "Özge" });  // Contains tanımlanan nesne yada değerin bu listede aradığımız değer varmı diye arama yapar. Bool tipinde true yada false olarak değer döndürür.
            Console.WriteLine("Liste içinde  newlenerek değer var mı diye bakıldı '{0}' sonucu döndürüldü.", icindeVarmi2);

            int indexBilgisi = musteriler.IndexOf(musteriDegerleri1); // Aranan Elemanın endex değerini gösterir int tipinde veri döndürür
            Console.WriteLine("Indexof ile index değeri alındı '{0}' sonucu döndürüldü.", indexBilgisi);

            int LastIndex = musteriler.LastIndexOf(musteriDegerleri1);//  Aramayı sondan  başlayarak yapar. verinin baştan itibaren index değerini dön
            Console.WriteLine("LastIndexof ile index değeri alındı '{0}' sonucu döndürüldü.", LastIndex);



            musteriler.Insert(0, musteriDegerleri1); // Insert işlemi ile istediğimiz veriyi istediğimiz index'e koyabiliriz. Add en sona eklerken insert ile istediğimiz endexe değer ekleriz diğerlerinide kaydırır  silmez !


          




            foreach (MusteriDegerleri m in musteriler)
            {
                Console.WriteLine("Müşteri id:{0} Adı: {1}", m.Id, m.Adi);
            }


            //  musteriler.Remove(musteriDegerleri1); // Eklemiş olduğumuz musteriDegerleri2 yi remove edebiliriz. Bulduğu ilk değeri uçurur. 

            musteriler.RemoveAll(m => m.Adi == "Ege");  // Bunu daha öğrenmedik ama bilgi notu olarak görelim.m=>m.Adi olarak liste içeriğiini ata ve Adi="Ege" olanları sil

            Console.WriteLine("-----------------------------------------");


            foreach (MusteriDegerleri m in musteriler)
            {
                Console.WriteLine("Müşteri id:{0} Adı: {1}", m.Id, m.Adi);
            }












            Console.ReadLine();

        }
    }

    class MusteriDegerleri  //Bir nesne oluşturup çalışıyoruz çünkü ; Genellikle veritabanı programlama yaptığımız için veritabanındaki tablolarımız karşılığını nesne halinde tutarız. Kayıtları bu şekilde veritabanından çekerek listeye atarız ve o listeyi kullanıcıya gösteririz bu bağlamda direk nesnelerle çalışmak önemli !
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }

}
