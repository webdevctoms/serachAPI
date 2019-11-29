using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SearchAPI.Models;
//use basic auth for 
//so "Basic " + base64 encoded pas and user
namespace SearchAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {   
        private Shirts shirts = new Shirts();
        private Pants pants = new Pants();
        [HttpGet]
        [Route("createShirts/{num}")]
        public Array CreateShirts(int num)
        {
            SingleShirt[] shirtArr = new SingleShirt[num];
            for(int i = 0;i < num; i++)
            {
                shirtArr[i] = shirts.CreateShirt();
            }
            return shirtArr;
        }
        
        [Route("createPants/{num}")]
        public Array CreatePants(int num)
        {
            SinglePant[] pantArr = new SinglePant[num];
            for(int i = 0;i < num; i++)
            {
                pantArr[i] = pants.CreatePant();
            }
            for(int i = 0;)
            int afterTime = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
            Console.WriteLine("Time after for loop: {0}", afterTime);
            return pantArr;
        }
        
    }
}