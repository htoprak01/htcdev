using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using Data_Layer;
namespace VKI_Business_Layer
{
    public class VKI_Services
    {
        private static List<VKI> VKIList = new List<VKI>();

        public static void SaveVKIList(VKI vKI)
        {
            VKIList.Add(vKI);

            //JSON serilaize
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.IncludeFields = true;
            string json = JsonSerializer.Serialize(VKIList, options);
            // write to file
            Filetransactions.Filewrite(json);

        }
        public static IReadOnlyCollection<VKI> GetVKIList()
        {
            string json = Filetransactions.Fileread();
            VKIList = JsonSerializer.Deserialize<List<VKI>>(json, new JsonSerializerOptions { IncludeFields = true });


            return VKIList.AsReadOnly();
        }
        public static IReadOnlyCollection<VKI> SearchByName(string name)
        {
            GetVKIList();
            //var SearchRecord=new List<VKI>();
            //foreach(var item in VKIList)
            //{
            //    if (item.Ad==name) SearchRecord.Add(item);
            //}
            //return SearchRecord.AsReadOnly();
            var ResultRec = VKIList.Where(a => a.Ad == name).ToList();
            return ResultRec;
        }

        public static void  RemoveRec(string name)
        {
            GetVKIList();
            var ResultDeleteList = VKIList.Where(a => a.Ad!= name).ToList();
            Filetransactions.DeleteFile();
            foreach(VKI item in ResultDeleteList)
            {
                VKI_Services.SaveVKIList(item);
            }
           
        }

    }
}
