using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAPI.Models
{
    public class Pants
    {
        private string[] Types = { "Jeans", "Shorts", "Dress Pants", "Sweat Pants"};
        private string[] WaistSizes = {"30","32","34","36","38","40"};
        private string[] genders = { "Male", "Female", "Unisex" };
        public static List<string> CreatedPants = new List<string>();
        private Random rand = new Random();

        public Pants()
        {

        }

        public SinglePant CreatePant()
        {
            string type = Types.GetValue(rand.Next(0, Types.Length)).ToString();
            string waistSize = WaistSizes.GetValue(rand.Next(0, WaistSizes.Length)).ToString();
            string gender = genders.GetValue(rand.Next(0, genders.Length)).ToString();
            SinglePant pant = new SinglePant(type, waistSize, gender);
            CreatedPants.Add(pant.GetName());
            return pant;

        }
    }
}
