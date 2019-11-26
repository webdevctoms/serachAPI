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
        [Route("get1")]
        public string get1()
        {
            return "get1";
        }
        
        [Route("get2")]
        public string get2()
        {
            return "get12";
        }
        
    }
}