using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class Filetransactions
    {
        private const string filename = "VKI_TextFile.txt";
        public static void Filewrite(string Data)
        {
            File.WriteAllText(filename,Data);
        }
        public static string Fileread()
        {
            if(File.Exists(filename))        
            return File.ReadAllText(filename);          
            return string.Empty;         
        }
        public static void DeleteFile()
        {
         
                File.Delete(filename);
           
        }
    }
}
