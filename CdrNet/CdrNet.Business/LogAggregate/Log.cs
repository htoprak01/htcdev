using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdrNet.Business.LogAggregate
{
    public class Log
    {

        public Logseviyeleri _Logseviyesi;
        public DateTime _Logtarihi;
        public string _Logmesaj;

        public Log(Logseviyeleri Logseviyesi,DateTime Logtarihi, string Logmesaj)
        {

            _Logseviyesi = Logseviyesi;
            _Logtarihi= Logtarihi;
            _Logmesaj= Logmesaj;

        }
    }
    
}
