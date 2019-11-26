using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAPI.Models
{
    public class Shirts
    {   //225 possible combinations
        private string[] colors = { "red", "blue", "yellow", "purple", "green" };
        private string[] sizes = { "X-Large", "Large", "Medium", "Small", "X-Small" };
        private string[] lengths = { "T-Shirt", "Long Sleeve" ,"Tank Top"};
        private string[] genders = { "Male", "Female", "Unisex" };
        public static List<string> CreatedShirts = new List<string>();
        private Random rand = new Random();

        public Shirts()
        {

        }

        public SingleShirt CreateShirt()
        {
            string color = colors.GetValue(rand.Next(0, colors.Length)).ToString();
            string size = sizes.GetValue(rand.Next(0, sizes.Length)).ToString();
            string length = lengths.GetValue(rand.Next(0, lengths.Length)).ToString();
            string gender = genders.GetValue(rand.Next(0, genders.Length)).ToString();

            SingleShirt shirt = new SingleShirt(color, size, length, gender);
            CreatedShirts.Add(shirt.GetName());
            return shirt;
        }
    }
}
