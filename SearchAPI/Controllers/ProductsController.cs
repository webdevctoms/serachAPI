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
        public SingleShirt get1(int num)
        {
            Console.WriteLine(num);
            SingleShirt shirt = shirts.CreateShirt();
            return shirt;
        }
        
        [Route("get2")]
        public string get2()
        {
            return "get12";
        }
        
    }
}