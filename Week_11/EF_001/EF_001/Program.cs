using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //toList ile bölümleri listeleceğiz
            void bolumleriListele()
            {


                HastaneSabahEntities hastane = new HastaneSabahEntities();
                var bolumler = hastane.Bolumler.ToList();
                Console.WriteLine($"Bölüm ID/\tBolum Adi :");
                Console.WriteLine("");
                //var sonuc = hastene.Bolumler.Where(x => x.BolumAd == ("Diş"));

                foreach (var bolum in bolumler)
                {
                    Console.WriteLine($"{bolum.ID}\t\t{bolum.BolumAd}");
                }
                var sonuc = hastane.Bolumler.Where(x => x.BolumAd.StartsWith("D"));

                foreach (var item in sonuc)
                {
                    //Console.WriteLine($"bolum id :  {item.ID } bolum adi :{item.BolumAd}";
                }




            }
            void DoktorlariListele()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var adlar = hastane.Doktorlar.Select(x => x.AdSoyad);
                    foreach (var item in adlar)
                    {
                        //Console.WriteLine($"Doktor adlari :{item}");



                    }

                }
            }
            //DoktorlariListele();
            void HisliAra()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {

                    Doktorlar doktor = hastane.Doktorlar.Find(4);
                    //Console.WriteLine($"{doktor.AdSoyad}  {doktor.Bolumler.BolumAd}");




                }



            }
            //HisliAra();

            void ilkKayit()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {

                    Doktorlar doktor = hastane.Doktorlar
                          .Where(x => x.AdSoyad == "Demet Evgar")
                          .First();
                    Console.WriteLine($"{doktor.AdSoyad}  {doktor.Bolumler.BolumAd} {doktor.SicilNo}");


                }

            }
            void ilkUcDoktor()
            {
                using (HastaneSabahEntities hasta = new HastaneSabahEntities())
                {
                    var doktor = hasta.Doktorlar.Take(3);
                    foreach (var item in doktor)
                    {
                        //Console.WriteLine(item.AdSoyad);
                    }



                }
            }
            //ilkUcDoktor();

            void SonUcDoktor()
            {

                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var ilkUc = hastane.Doktorlar.OrderByDescending(x => x.ID).Take(3);


                    foreach (var item in ilkUc)
                    {
                        //Console.WriteLine(item.AdSoyad);

                    }


                }


            }

            SonUcDoktor();

            Console.ReadLine();

            void isThere()
            {
                //using (HastaneSabahEntities hasta = new HastaneSabahEntities())
                //{
                //    //bool sonuc = hasta.Doktorlar.Any(x=>x.AdSoyad=="Demet Evgar");
                //}  



            }

            void UyuyorMu()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    bool sonuc = hastane.Doktorlar.All(x => x.Bolumler.BolumAd == "Dahiliye");

                    if (sonuc)
                    {
                        //Console.WriteLine("evet uyuyor");

                    }
                }


            }

            void BolumlereGoreDoktorGetir()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {

                    var sonuc = hastane.Doktorlar.GroupBy(x => x.Bolumler.BolumAd).Select(x1 => new
                    {
                        name = x1.Key,
                        count = x1.Count()


                    });
                    foreach (var item in sonuc)
                    {
                        Console.WriteLine($"{item.name}\t{item.count}");
                    }
                }

                Console.ReadLine();

            }
            BolumlereGoreDoktorGetir();



        }
    }
}










