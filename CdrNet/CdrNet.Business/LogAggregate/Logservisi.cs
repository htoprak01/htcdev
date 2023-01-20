using CdrNet.Business.KasaAggregate;
using CdrNet.Data.Txt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CdrNet.Business.LogAggregate
{
    public class Logservisi
    {
        public static  List<Log> loglist=new List<Log>();
        
        private static void LogYukle()
        {
            CdrNet.Data.Txt.DosyaIslemleri.Oku(Sabitler.LOG_DOSYA_YOLU);
        }
        public static void ErrorLog(string hatamesaji)
        {
            Log logrec = new Log(Logseviyeleri.Error, DateTime.Now, hatamesaji);
            loglist.Add(logrec);
            SaveLog();
        }
        public static void WarningLog(string hatamesaji)
        {
            Log logrec = new Log(Logseviyeleri.Warning, DateTime.Now, hatamesaji);
            loglist.Add(logrec);
            SaveLog(); 
        }
        public static void informationLog(string hatamesaji)
        {
            Log logrec = new Log(Logseviyeleri.Information, DateTime.Now, hatamesaji);
            loglist.Add(logrec);
            SaveLog();
        }

        public static void SaveLog()

        {
          
            string json = JsonSerializer.Serialize(loglist, new JsonSerializerOptions { IncludeFields = true });
            DosyaIslemleri.Kaydet(Sabitler.LOG_DOSYA_YOLU, json);

        }
    }

}
