using System;

class Program
{
    static void Main()
    {
        Console.Write("Araç kalma süresi (saat): ");
        int sure = Convert.ToInt32(Console.ReadLine());

        Console.Write("Araç türü (1: Otomobil, 2: Kamyon, 3: Iş makinası): ");
        int aracTur = Convert.ToInt32(Console.ReadLine());

        double ucret = 0;

        switch (aracTur)
        {
            case 1: 
                ucret = HesaplaOtomobilUcret(sure);
                break;
            case 2:
                ucret = HesaplaKamyonUcret(sure);
                break;
            case 3:
                ucret = HesaplaIsMakinasiUcret(sure);
                break;
            default:
                Console.WriteLine("Geçersiz araç türü!");
                break;
        }

        Console.WriteLine($"Toplam çıkış ücreti: {ucret} TL");
        Console.ReadLine();
    }

    static double HesaplaOtomobilUcret(int sure)
    {
        double ucret = 0;

        if (sure <= 2)
        {
            ucret = 5;
        }
        else if (sure <= 24)
        {
            ucret = 5 + (sure - 2) / 1 * 1;
        }
        else
        {
            ucret = 13;

            int gunSayisi = (sure - 24) / 24;

            if ((sure - 24) % 24 > 0)
            {
                ucret += 5;
            }

            ucret += gunSayisi * 13;

            ucret += (sure % 24 - 2) * 1;
        }

        return ucret;
    }




    static double HesaplaKamyonUcret(int sure)
    {
        double ucret = 0;

        if (sure <= 2)
        {
            ucret = 8;
        }
        else if (sure <= 24)
        {
            ucret = 8 + (sure - 2) / 1 * 1;
        }
        else
        {
            ucret = 18;

            int gunSayisi = (sure - 24) / 24;

            if ((sure - 24) % 24 > 0)
            {
                ucret += 8;
            }

            ucret += gunSayisi * 18;

            ucret += (sure % 24 - 2) * 1;
        }

        return ucret;
    }

    static double HesaplaIsMakinasiUcret(int sure)
    {
        double ucret = 0;

        if (sure <= 2)
        {
            ucret = 12;
        }
        else if (sure <= 24)
        {
            ucret = 12 + (sure - 2) / 1 * 1;
        }
        else
        {
            ucret = 27;

            int gunSayisi = (sure - 24) / 24;

            if ((sure - 24) % 24 > 0)
            {
                ucret += 12;
            }

            ucret += gunSayisi * 27;

            ucret += (sure % 24 - 2) * 1;
        }

        return ucret;
    }
}
