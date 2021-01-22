using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("ID     " +
                " : {0}\nAd      : {1} \nSoyad   : {2}\nTelefon : {3}\nAdres   : {4}\nMüşteri başarıyla kaydedilmiştir.",musteri.Id,musteri.Ad,musteri.Soyad,musteri.Telefon,musteri.Adres);
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("ID      : {0}\nAd      : {1} \nSoyad   : {2}\nTelefon : {3}\nAdres   : {4}\nMüşteri bilgileri başarıyla listelenmiştir.", musteri.Id, musteri.Ad, musteri.Soyad, musteri.Telefon, musteri.Adres);
        }
        public void MusteriDuzenle(Musteri musteri)
        {
            Console.WriteLine("ID      : {0}\nAd      : {1} \nSoyad   : {2}\nTelefon : {3}\nAdres   : {4}\nMüşteri bilgileri başarıyla güncellenmiştir.", musteri.Id, musteri.Ad, musteri.Soyad, musteri.Telefon, musteri.Adres);
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("ID      : {0}\nAd      : {1} \nSoyad   : {2}\nTelefon : {3}\nAdres   : {4}\nMüşteri Başarıyla silinmiştir.", musteri.Id, musteri.Ad, musteri.Soyad, musteri.Telefon, musteri.Adres);
        }
        public void TumMusterileriListele(Musteri[] musteri)
        {
            foreach (var m in musteri)
            {
                Console.WriteLine("ID      : {0}\nAd      : {1} \nSoyad   : {2}\nTelefon : {3}\nAdres   : {4}\n",m.Id,m.Ad,m.Soyad,m.Telefon,m.Adres);
            }
        }
    }
}
