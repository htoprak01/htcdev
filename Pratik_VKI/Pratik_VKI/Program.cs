
// See https://aka.ms/new-console-template for more information
using System;
bool bitis = true;
bool secim = false;
do
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.WriteLine("----------------VKI HESAPLAMA TABLOSU------");
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Write("Boyunuzu giriniz(cm):");
    double boy = (Convert.ToDouble(Console.ReadLine())) / 100;
    Console.Write("Kilonuzu giriniz(kg):");
    double kilo = Convert.ToDouble(Console.ReadLine());
    double VKI = Math.Round((kilo / (boy * boy)), 2);
    Console.WriteLine("VKI:" + VKI);
    if (VKI < 18.49)
    {
        Console.WriteLine("Hastanın; boyu:" + boy + "kilosu:" + kilo + " VKI indeksi" + VKI + "Teşhis: ZAYIF");
    }
    else if (VKI > 18.50 && VKI < 24.99)
    {
        Console.WriteLine("Hastanın; boyu:" + boy + "kilosu:" + kilo + " VKI indeksi" + VKI + "Teşhis: IDEAL");
    }
    else if (VKI > 25 && VKI < 29.99)
    {
        Console.WriteLine("Hastanın; boyu:" + boy + "kilosu:" + kilo + " VKI indeksi" + VKI + "Teşhis: HAFİF KİLOLU");
    }
    else if (VKI > 30)
    {
        Console.WriteLine("Hastanın; boyu:" + boy + "kilosu:" + kilo + " VKI indeksi" + VKI + "Teşhis: OBEZ");
    }
    Console.WriteLine();
    Console.WriteLine("Devam etmek istiyormusunuz(e/h");

    do
    {
        char son = Console.ReadKey().KeyChar;

        if (son == 'e' || son == 'E')
        {
            bitis = true; secim = false;
        }
        else if (son == 'h' || son == 'H')
        {
            bitis = false; secim = false;
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız..tekrar deneyin."); secim = true;
        }
    } while (secim);

}
while (bitis);

//“Hastanın; boyu: 1.73, kilosu: 70, VKI indeksi: 25, Teşhis: Hafif Kilol
//VKİ 18,49 ‘un altı ZAYIF 
//VKİ 18,5 – 24,99 arası İDEAL 
//VKİ 25 - 29,99 arası ise HAFİF KİLOLU 
//VKİ 30 ‘un üstü OBEZ

