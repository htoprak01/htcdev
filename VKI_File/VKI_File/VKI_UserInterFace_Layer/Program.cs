using System.Runtime.InteropServices;
using VKI_Business_Layer;
namespace VKI_Application
{
    public class Program
    {
        public static void Main()
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------VKI Uygulaması------");
            Console.WriteLine("1-VKI Hesaplama\n2-Listeleme\n3-Arama\n4-Çıkış");
            MenuSelection();
        }

        public static void MenuSelection()
        {
            Console.WriteLine("Seçim Yapınız(1-4)");
            string secim=Console.ReadLine();
            switch(secim)
            {
                case "1":NewVKIRec(); break;
                case "2":DumpVKILists(); break;
                case "3":VKISearch(); break;
                case "4":Environment.Exit(0);break;
                default:Console.WriteLine("Hatalı Seçim"); MenuSelection();break;
            }
        }

        public static void NewVKIRec()
        {
            do
            {
                Console.Clear();
                VKI vki = new VKI();
                Console.Write("Kişi Adını Giriniz:");
                vki.Ad = Console.ReadLine();
                Console.Write("Kişi Soyadını Giriniz:");
                vki.Soyad = Console.ReadLine();
                Console.Write("Telefonuzu Giriniz:");
                vki.TelNo = Console.ReadLine();
                Console.Write("Boyunuzu Giriniz(cm):");
                vki.Boy = Convert.ToDouble(Console.ReadLine());
                Console.Write("Klilonuzu Giriniz:");
                vki.Kilo = Convert.ToDouble(Console.ReadLine());
                VKI_Services.SaveVKIList(vki);
                DumpToScreen(vki);
            } while (Devamdurumu());
            Menu();


            
        }
        static bool Devamdurumu()

        {
            Console.Write("Devam mı(e/h)?'");
            char devam = Console.ReadKey().KeyChar;

            if (devam == 'e' || devam == 'E')
            { return true; }
            else if (devam == 'h' || devam == 'H')
            { return false; }
            else { Console.WriteLine("Hatalı Giriş Yaptınız Tekrar deneyin.."); return Devamdurumu(); }
        }
        private static void Again()
        {
            Console.WriteLine("Menüye dönmek için ENTER");
            Console.ReadLine();
            Menu();
        }
        public static void DumpVKILists()
        {
            var vki_list=VKI_Services.GetVKIList();
            foreach(VKI vki in vki_list)
            {
                DumpToScreen(vki); ;
            }
            Again();
        }
        private static void VKISearch()
        {
            Console.Write("Aranacak İsmi Giriniz:");
            string searchname = Console.ReadLine();
            var Search_VKI_List=VKI_Services.SearchByName(searchname);
            foreach (VKI vki in Search_VKI_List)
            {
                DumpToScreen(vki); ;
            }
            Again();

        }
        public static void DumpToScreen(VKI v)
        {
            Console.WriteLine($"Adı:{v.Ad} Soyadı:{v.Soyad} Telefonu:{v.TelNo} Boyu:{v.Boy} Kilosu:{v.Kilo} VKI:{v.VKI_Hesapla()} Teşhis:{v.VKI_Stat()}");
        }

    }
}