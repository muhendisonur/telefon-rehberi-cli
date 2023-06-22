public class Rehber
{
    Arayuz arayuz = new Arayuz();

    public void Goster(List<Kisi> listePara)
    {
        foreach(Kisi item in listePara)
        {
            KisiGoster(item);
        }
    }

    public void KisiGoster(Kisi kisiPara) //Kisi türünde ki nesnelerin içeriklerini yazar
    {
        System.Console.WriteLine(
            "İsim               : {0}\n" +
            "Soyisim            : {1}\n" +
            "Telefon Numarası   : {2}\n" +
            "************************************************"
        , kisiPara.isim, kisiPara.soyisim, kisiPara.telefonNumarasi);
    }

    public void Ekle(List<Kisi> listePara, Kisi kisiPara = null)
    {
        if(kisiPara == null)
        {
            arayuz.Isim(out string isim);
            arayuz.SoyIsim(out string soyIsim);
            arayuz.TelefonNumarasi(out string telefonNumarasi);
            listePara.Add(new Kisi(isim, soyIsim, telefonNumarasi));
        }
        else
        {
            listePara.Add(kisiPara);
        }

        System.Console.WriteLine("Kişi başarıyla eklendi.");
    }

    public void Sil(List<Kisi> listePara)
    {
        arayuz.Silme(out string silinecek);
        bool bulundu = false;

        foreach(Kisi item in listePara)
        {
            if(item.isim == silinecek || item.soyisim == silinecek)
            {
                bulundu = true;
                arayuz.SilmeOnay(silinecek ,out string silmeOnayCevap);
                if(silmeOnayCevap == "e")
                {
                    listePara.Remove(item);
                    System.Console.WriteLine("Kişi başarıyla silindi!");
                    break;
                }    
                else
                    break;
            }
        }
        
        if(!bulundu)
        {
            arayuz.SilmeBulunamadi(out int bulunamadiCevap);

            if(bulunamadiCevap == 2)
                Sil(listePara);
        }
    }

    public void Guncelle(List<Kisi> listePara)
    {
        bool guncellemeBulundu = false;
        arayuz.Guncelleme(out string guncellenecek);
        foreach(Kisi item in listePara)
        {
            if(item.isim == guncellenecek || item.soyisim == guncellenecek)
            {
                guncellemeBulundu = true;
                arayuz.TelefonNumarasi(out string yeniNumara);
                item.telefonNumarasi = yeniNumara;
                System.Console.WriteLine("Numara Güncellendi!");
                break;
            }
        }

        if(!guncellemeBulundu)
        {
            arayuz.GuncelleBulunamadi(out int guncellemeCevap);

            if(guncellemeCevap == 2)
                Guncelle(listePara);
        }
    }

    public void Ara(List<Kisi> listePara)
    {
        arayuz.Arama(out int aramaCevap);

        if(aramaCevap == 1)
        {
            arayuz.Isım_SoyIsım(out string isim_soyisim);
            bool bulundu = false;
            foreach(Kisi item in listePara)
            {
                if(item.isim == isim_soyisim || item.soyisim== isim_soyisim)
                {
                    bulundu = true;
                    System.Console.WriteLine("Arama bulundu!");
                    break;
                }
            }

            if(!bulundu)
                System.Console.WriteLine("Arama bulunamadı!");
        }
        else if(aramaCevap == 2)
        {
            arayuz.TelefonNumarasi(out string telNo);
            bool bulundu = false;
            foreach(Kisi item in listePara)
            {
                if(item.telefonNumarasi == telNo)
                {
                    bulundu = true;
                    System.Console.WriteLine("Arama bulundu!");
                    break;
                }
            }

            if(!bulundu)
                System.Console.WriteLine("Arama bulunamadı!");
        }
        else
            System.Console.WriteLine("Hatalı giriş!");
    }
}