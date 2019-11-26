using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAPI.Models
{
    public class SingleShirt
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public string Length { get; set; }
        public string Gender { get; set; }
        public SingleShirt(string color, string size,string length, string gender)
        {
            Color = color;
            Size = size;
            Length = length;
            Gender = gender;
        }

        public string GetName()
        {
            return Gender + " " + Color + " " + Size + " " + Length + " ";
        }
    }
}
