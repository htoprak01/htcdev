
// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;



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
    double vki = Math.Round((kilo / (boy * boy)), 2);
    SonucYaz(kilo, boy, vki);

} while (Devamdurumu()) ;
    static void  SonucYaz(double kilo,double boy,double vki)
{
    Console.WriteLine("Hastanın; boyu:" + boy + " kilosu:" + kilo + " VKI indeksi:" + vki +" Teşhis:"+Sonuc(vki));
    
    
}
 static string Sonuc(double vki)
    {
       if (vki<18.49) { return "ZAYIF"; }
       else if(vki > 18.50 && vki < 24.99) { return "ZAYIF"; }
        else if (vki > 18.50 && vki < 24.99) { return "IDEAL"; }
        else if (vki> 25 && vki < 29.99) { return "HAFİF KİLOLU"; }
        else if (vki> 30) { return "OBEZ"; }
        else  { return "DIĞRER"; }
}

static bool  Devamdurumu()

{ Console.Write("Devam mı(e/h)?'");
    char devam = Console.ReadKey().KeyChar;

    if (devam=='e'|| devam=='E')
    { return true; }
    else if(devam=='h'||devam=='H')
    { return false; }
    else { Console.WriteLine("Hatalı Giriş Yaptınız Tekrar deneyin.."); return Devamdurumu(); }
}





