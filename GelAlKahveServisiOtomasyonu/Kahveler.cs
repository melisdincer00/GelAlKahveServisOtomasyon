
using Otomasyon;
using System;


namespace Otomasyon
{
  
    abstract class KahveMakinesi
    {
        abstract public void KahveEkle();
        abstract public void SutEkle();
        

        public void MakineCalistir()
        {
            
        }

        public void MakineKapat()
        {
            
        }
    }

    class EspressoMakinesi : KahveMakinesi
    {
        public override void KahveEkle()
        {
           
        }

        public override void SutEkle()
        {
           
        }
    }
   

    class AmericanoMakinesi : KahveMakinesi
    {
        public int KahveMiktari { get; set; }
        public override void KahveEkle()
        {
          
        }

        public override void SutEkle()
        {
            
        }
    }
        public class KahveSiparis

        {
            public int KahveId { get; set; }
            public int Fiyat { get; set; }
            public string BardakBoy { get; set; }
            public float SekerMiktar { get; set; }
            public int KahveAdet;
            public Musteri MusteriAd { get; set; }
            public Calisan CalisanAdi { get; set; }

        }
        public class Musteri
        {
            public int MusteriId { get; set; }
            public string MusteriAdi { get; set; }
            public string Email { get; set; }
            public long TelNo { get; set; }
            public List<KahveSiparis> Siparisler { get; set; } = new List<KahveSiparis>();// Bir müşteri birden  fazla kahve siparişi verebilir.
        }

        public class Calisan
        {
            public int CalisanId { get; set; }
            public string CalisanAdi { get; set; }
            public string CalisanSoyad { get; set; }
            public List<KahveSiparis> Siparisler { get; set; } = new List<KahveSiparis>(); //Çalışanın hazırladığı siparişleri tutmak için 


        }


        public class Espresso : KahveSiparis
        {
            public int SertlikDerecesi { get; set; }
            public override string ToString()
            {
                return $"Fiyat: {Fiyat} TL, Bardak Boyu: {BardakBoy}, Şeker Miktarı: {SekerMiktar}, Kahve Adedi: {KahveAdet}";
            }

        }

        public class Americano : KahveSiparis
        {
            public bool BuzluMu { get; set; }
            public override string ToString()
            {
                return $"Fiyat: {Fiyat} TL, Bardak Boyu: {BardakBoy}, Şeker Miktarı: {SekerMiktar}, Kahve Adedi: {KahveAdet}";
            }
            public Musteri MusteriAd { get; set; }
            public Calisan CalisanAdi { get; set; }

        }
        public class Cappucino : KahveSiparis
        {
            public bool SutKopugu { get; set; }//Üzerine eklemek için
            public override string ToString()
            {
                return $"Fiyat: {Fiyat} TL, Bardak Boyu: {BardakBoy}, Şeker Miktarı: {SekerMiktar}, Kahve Adedi: {KahveAdet}";
            }

        }

    class Program
    {
        static void Main()
        {
            EspressoMakinesi espressoMakinesi = new EspressoMakinesi();
            AmericanoMakinesi americanoMakinesi = new AmericanoMakinesi();

            espressoMakinesi.MakineCalistir();
            espressoMakinesi.KahveEkle();
            espressoMakinesi.SutEkle();
            espressoMakinesi.MakineKapat();

            americanoMakinesi.MakineCalistir();
            americanoMakinesi.KahveEkle();
            americanoMakinesi.SutEkle();
            americanoMakinesi.MakineKapat();
        }
   
    }




}

    
      
