List<Kisi> rehber = new List<Kisi>();
Arayuz arayuz = new Arayuz();
Rehber kontrolcu = new Rehber();

rehber.Add(new Kisi("onur", "yıldız", "152512512"));

while(true)
{
    arayuz.Navigasyon(out int navIslem);

    switch(navIslem)
    {
        case 1: //rehbere kişi ekleme
            bosluk();
            kontrolcu.Ekle(rehber);
            bosluk();
            break;

        case 2: //rehberden kişi silme
            bosluk();
            kontrolcu.Sil(rehber);
            bosluk();
            break;

        case 3: //rehberde numara güncelleme
            bosluk();
            kontrolcu.Guncelle(rehber);
            bosluk();
            break;

        case 4: //rehberi listeleme
            bosluk();
            System.Console.WriteLine("**************** REHBER LISTESI ****************");
            foreach(Kisi item in rehber)
            {
                kontrolcu.Goster(item);
            }
            bosluk();
            break;

        case 5: //rehberde arama
            bosluk();
            kontrolcu.Ara(rehber);
            bosluk();
            break;
    
    }
}

void bosluk(int olcek = 1)
{
    for(int i = 0; i < olcek; i++)
        System.Console.WriteLine();
}