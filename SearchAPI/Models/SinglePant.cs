using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAPI.Models
{
    public class SinglePant
    {
        public string Product_type { get; set; }
        public string Type { get; set; }
        public string WaistSize { get; set; }
        public string Gender { get; set; }

        public SinglePant(string type, string waistSize, string gender)
        {
            Type = type;
            WaistSize = waistSize;
            Gender = gender;
            Product_type = "Pants";
        }
        public string GetName()
        {
            return Gender + " " + Type + " " + WaistSize;
        }
    }
}
