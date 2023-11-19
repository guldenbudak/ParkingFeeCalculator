using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan aracın kalma süresini ve türünü al
        Console.Write("Araç kalma süresi (saat): ");
        int sure = Convert.ToInt32(Console.ReadLine());

        Console.Write("Araç türü (1: Otomobil, 2: Kamyon, 3: Iş makinası): ");
        int aracTur = Convert.ToInt32(Console.ReadLine());

        double ucret = 0;

        // Aracın türüne göre ücreti hesapla
        switch (aracTur)
        {
            case 1: // Otomobil
                ucret = HesaplaOtomobilUcret(sure);
                break;
            case 2: // Kamyon
                ucret = HesaplaKamyonUcret(sure);
                break;
            case 3: // Iş makinası
                ucret = HesaplaIsMakinasiUcret(sure);
                break;
            default:
                Console.WriteLine("Geçersiz araç türü!");
                break;
        }

        // Sonucu ekrana yazdır
        Console.WriteLine($"Toplam çıkış ücreti: {ucret} TL");
        Console.ReadLine();
    }

    static double HesaplaOtomobilUcret(int sure)
    {
        double ucret = 0;

        // İlk 2 saat için ücret
        if (sure <= 2)
        {
            ucret = 5;
        }
        else if (sure <= 24)
        {
            // 2 saatten 24 saate kadar her saat başı 1 TL
            ucret = 5 + (sure - 2) / 1 * 1;
        }
        else
        {
            // 24 saati geçerse günlük sabit ücret
            ucret = 13;

            // 24 saati aşan süreler için günlük ücretin eklenmesi
            int gunSayisi = (sure - 24) / 24;

            // Eğer tam gün geçmişse bir gün ücretini ekleyelim
            if ((sure - 24) % 24 > 0)
            {
                ucret += 5;
            }

            // 24 saatten fazla süre varsa bir gün ücretini tekrar ekleyelim
            ucret += gunSayisi * 13;

            // Geri kalan saatler için saat başına 1 TL ekleyelim
            ucret += (sure % 24 - 2) * 1;
        }

        return ucret;
    }




    static double HesaplaKamyonUcret(int sure)
    {
        double ucret = 0;

        // İlk 2 saat için ücret
        if (sure <= 2)
        {
            ucret = 8;
        }
        else if (sure <= 24)
        {
            // 2 saatten 24 saate kadar her saat başı 1 TL
            ucret = 8 + (sure - 2) / 1 * 1;
        }
        else
        {
            // 24 saati geçerse günlük sabit ücret
            ucret = 18;

            // 24 saati aşan süreler için günlük ücretin eklenmesi
            int gunSayisi = (sure - 24) / 24;

            // Eğer tam gün geçmişse bir gün ücretini ekleyelim
            if ((sure - 24) % 24 > 0)
            {
                ucret += 8;
            }

            // 24 saatten fazla süre varsa bir gün ücretini tekrar ekleyelim
            ucret += gunSayisi * 18;

            // Geri kalan saatler için saat başına 1 TL ekleyelim
            ucret += (sure % 24 - 2) * 1;
        }

        return ucret;
    }

    static double HesaplaIsMakinasiUcret(int sure)
    {
        double ucret = 0;

        // İlk 2 saat için ücret
        if (sure <= 2)
        {
            ucret = 12;
        }
        else if (sure <= 24)
        {
            // 2 saatten 24 saate kadar her saat başı 1 TL
            ucret = 12 + (sure - 2) / 1 * 1;
        }
        else
        {
            // 24 saati geçerse günlük sabit ücret
            ucret = 27;

            // 24 saati aşan süreler için günlük ücretin eklenmesi
            int gunSayisi = (sure - 24) / 24;

            // Eğer tam gün geçmişse bir gün ücretini ekleyelim
            if ((sure - 24) % 24 > 0)
            {
                ucret += 12;
            }

            // 24 saatten fazla süre varsa bir gün ücretini tekrar ekleyelim
            ucret += gunSayisi * 27;

            // Geri kalan saatler için saat başına 1 TL ekleyelim
            ucret += (sure % 24 - 2) * 1;
        }

        return ucret;
    }
}
