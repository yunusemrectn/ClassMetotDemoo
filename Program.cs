using System;

namespace ClassMetotDemo
{
    class Program
    {
        static string DevamEt()
        {
            Console.Write("1-Devam Et, 2-Bitir : ");
            string secimDB = Console.ReadLine();
            return secimDB;
        }
        static void Main(string[] args)
        {
            Musteri veri1 = new Musteri();
            veri1.Id = 0;
            veri1.Ad = "Yunus Emre";
            veri1.Soyad = "ÇETİN";
            veri1.Telefon = "5075532479";
            veri1.Adres = "Esenyurt/İstanbul";

            Musteri veri2 = new Musteri();
            veri2.Id = 1;
            veri2.Ad = "Ali Osman";
            veri2.Soyad = "UZUN";
            veri2.Telefon = "5325748512";
            veri2.Adres = "Avcılar/İstanbul";

            Musteri veri3 = new Musteri();
            veri3.Id = 2;
            veri3.Ad = "Hüseyin";
            veri3.Soyad = "BOZDEMİR";
            veri3.Telefon = "5533412121";
            veri3.Adres = "Avcılar/İstanbul";

            Musteri veri4 = new Musteri();
            veri4.Id = 3;
            veri4.Ad = "Samet Fazıl";
            veri4.Soyad = "ŞENTÜRK";
            veri4.Telefon = "5533412151";
            veri4.Adres = "Esenyurt/İstanbul";

            Musteri[] musteriler =  {veri1, veri2, veri3, veri4};

            baslangicTekrari:
            Console.WriteLine("\n______Sisteme Hoş Geldiniz!______");
            Console.WriteLine("|     1-Müşteri Kayıt Ekranı    |");
            Console.WriteLine("|    2-Müşteri Listeme Ekranı   |");
            Console.WriteLine("|   3-Müşteri Düzenleme Ekranı  |");
            Console.WriteLine("|     4-Müşteri Silme Ekranı    |");
            Console.WriteLine("|    5-Tüm Müşterileri Göster   |");
            Console.Write("Lütfen yaptırmak istediğiniz işlemin numarasını giriniz:");
            string seciliIslem = Console.ReadLine();
            Console.WriteLine();
            MusteriManager musteriBilgileri = new MusteriManager();
            switch (seciliIslem)
            {
                case "1":
                    musteriBilgileri.MusteriEkle(veri1);
                    if (DevamEt() == "1")
                        goto baslangicTekrari;
                    else
                        break;
                case "2":
                    musteriBilgileri.MusteriListele(veri2);
                    if (DevamEt() == "1")
                        goto baslangicTekrari;
                    else
                        break;
                case "3":
                    musteriBilgileri.MusteriDuzenle(veri3);
                    if (DevamEt() == "1")
                        goto baslangicTekrari;
                    else
                        break;
                case "4":
                    musteriBilgileri.MusteriSilme(veri4);
                    if (DevamEt() == "1")
                        goto baslangicTekrari;
                    else
                        break;
                case "5":
                    musteriBilgileri.TumMusterileriListele(musteriler);
                    if (DevamEt() == "1")
                        goto baslangicTekrari;
                    else
                        break;
                default:
                    Console.WriteLine("Geçersiz bir işlem numarası girişi yaptınız. Lütfen tekrar deneyiniz.\n");
                    goto baslangicTekrari;
            }
            Console.ReadKey();
        }
    }
}
