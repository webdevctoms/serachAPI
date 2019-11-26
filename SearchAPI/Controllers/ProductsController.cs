using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SearchAPI.Models;

namespace SearchAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {   
        private Shirts shirts = new Shirts();
        [HttpGet]
        [Route("createShirts/{num}")]
        public Array GetShirts(int num)
        {

            Console.WriteLine(num);
            //SingleShirt shirt = shirts.CreateShirt();
            SingleShirt[] shirtArr = new SingleShirt[num];
            for(int i = 0;i < num; i++)
            {
                shirtArr[i] = shirts.CreateShirt();
            }
            return shirtArr;
        }
        
        [Route("get2")]
        public string get2()
        {
            return "get12";
        }
        
    }
}