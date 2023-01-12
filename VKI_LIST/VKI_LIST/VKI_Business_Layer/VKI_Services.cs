using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKI_Business_Layer
{
    public class VKI_Services
    {
        private static List<VKI> VKIList = new List<VKI>();

       public static void SaveVKIList(VKI vKI)
        {
            VKIList.Add(vKI);
        }
        public static IReadOnlyCollection<VKI> GetVKIList() 
        { 
            return VKIList.AsReadOnly();
        }

    }
}
