public class Kisi 
{
    string _isim;
    string _soyIsim;
    string _telefonNumarasi;

    public string isim 
    {
        get => _isim;
        set
        {
            if(value.RakamVar())
                throw new Exception("Hata: Sadece harf giriniz!");
            else
                _isim = value;
        } 
    }

    public string soyisim 
    {
        get => _soyIsim;
        set
        {
            if(value.RakamVar())
                throw new Exception("Hata: Sadece harf giriniz!");
            else
                _soyIsim = value;
        } 
    }

    public string telefonNumarasi 
    {
        get => _telefonNumarasi;
        set
        {
            if(value.HarfVar())
                throw new Exception("Hata: Sadece rakam giriniz!");
            else
                _telefonNumarasi = value;
        } 
    }

    public Kisi() {} //yapıcı metot

    public Kisi(string isimPara, string soyIsimPara, string telefonNumarasiPara) //yapıcı metot ile veri girişi
    {
        isim = isimPara;
        soyisim = soyIsimPara;
        telefonNumarasi = telefonNumarasiPara;
    }

}