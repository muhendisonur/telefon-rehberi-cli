//Extension Methods
public static class degerKontrolu //string ifadelerin rakam veya harf içermelerinin kontrolünü sağlayan metotları içerir
{
    public static bool HarfVar(this string param)
    {
        for(int i = 97; i < 122; i++)
        {
            if(param.Contains(Convert.ToChar(i))) //ASCII tablosuna göre 97 a harfine 122 ise z harfine denk gelir. Dolayısıyla sayısal verilerin char'a dönüşümünden ortaya çıkan alfabeden harf kontrolü gerçekleştirilir.
            {
                return true;
            }
        }

        return false;
    }

    public static bool RakamVar(this string param)
    {
        for(int i = 0; i < 9; i++)
        {
            if(param.Contains(Convert.ToString(i)))
            {
                return true;
            }
        }
        return false;
    }
}