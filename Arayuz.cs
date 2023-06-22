public struct Arayuz
{
    //Genel, Karşılama
    public void Navigasyon(out int cevap)
    {
        System.Console.WriteLine(
            "(1) Yeni Numara Kaydet\n" +
            "(2) Varolan Numarayı Sil\n" +
            "(3) Varolan Numarayı Güncelle\n" +
            "(4) Rehberde ki Kişileri Göster\n" +
            "(5) Rehberde Arama Yap\n"
        );
        System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
        cevap = int.Parse(Console.ReadLine());
    }

    //Yeni Kayıt
    public void Isim(out string cevap)
    {
        System.Console.WriteLine("Lütfen isim giriniz: ");
        cevap = Console.ReadLine();
    }

    public void SoyIsim(out string cevap)
    {
        System.Console.WriteLine("Lütfen soyisim giriniz: ");
        cevap = Console.ReadLine();
    }

     public void Isım_SoyIsım(out string cevap)
    {
        System.Console.WriteLine("Lütfen isim veya soyisim giriniz: ");
        cevap = Console.ReadLine();
    }

    public void TelefonNumarasi(out string cevap)
    {
        System.Console.WriteLine("Telefon numarası giriniz: ");
        cevap = Console.ReadLine();
    }

    //Numara Silme
    public void Silme(out string cevap)
    {
        System.Console.WriteLine("Lütfen numarısını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
        cevap = Console.ReadLine();
    }
    public void SilmeBulunamadi(out int cevap)
    {
        System.Console.WriteLine(
            "(1) Silmeyi sonlandır\n" +
            "(2) Yeniden dene\n" +
            "Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız: "
        );
        cevap = int.Parse(Console.ReadLine());
    }
    public void SilmeOnay(string isim, out string cevap)
    {
        System.Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (e/h): ", isim);
        cevap = Console.ReadLine();
    }

    //Güncelleme
    public void Guncelleme(out string cevap)
    {
        System.Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
        cevap = Console.ReadLine();
    }
    public void GuncelleBulunamadi(out int cevap)
    {
        System.Console.WriteLine(
            "(1) Güncellemeyi sonlandır\n" +
            "(2) Yeniden dene\n" +
            "Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız: "
        );
        cevap = int.Parse(Console.ReadLine());
    }

    //Arama
    public void Arama(out int cevap)
    {
        System.Console.WriteLine(
            "(1) İsim veya soyisime göre arama yap\n" +
            "(2) Telefon numarasına göre arama yap\n" +
            "Arama yapmak istediğiniz tipi seçiniz: "
        );
        cevap = int.Parse(Console.ReadLine());
    }
}