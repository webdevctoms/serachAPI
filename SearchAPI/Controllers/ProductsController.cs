using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
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
        private static readonly HttpClient client = new HttpClient();
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
            var pass = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in pass)
            {
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);
            }
            for (int i = 0;i < num; i++)
            {
                pantArr[i] = pants.CreatePant();
            }
            for(int i = 0;i < pantArr.Length; i++)
            {
                int loopTime = DateTime.UtcNow.Millisecond;
                Console.WriteLine($"Loop time {loopTime} index: {i}");
                
                Thread.Sleep(1000);
            }
            int afterTime = DateTime.UtcNow.Millisecond;
            Console.WriteLine("Time after for loop: {0}", afterTime);
            return pantArr;
        }
        
    }
}