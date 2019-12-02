using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SearchAPI.Models;
using SearchAPI.tools;


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
        private GetConfig config = new GetConfig();
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
        public async Task<Array> CreatePants(int num)
        {
            SetHeaders();
            SinglePant[] pantArr = new SinglePant[num];
            String[] pantJsonStrings = new string[num];

            string postUrl = config.Url + "/products/_doc/";
            for (int i = 0;i < num; i++)
            {
                pantArr[i] = pants.CreatePant();
            }

            for (int i = 0; i < num; i++)
            {
                pantJsonStrings[i] = pants.ConvertToJson(pantArr[i]);
            }
            for (int i = 0;i < pantJsonStrings.Length; i++)
            {
                int loopTime = DateTime.UtcNow.Millisecond;
                Console.WriteLine($"Loop time {loopTime} index: {i} {pantJsonStrings[i]}");
                var response = await client.PostAsync(postUrl,new StringContent(pantJsonStrings[i],Encoding.UTF8,"application/json"));
                Console.WriteLine($"{response}");
                //Thread.Sleep(1000);
            }
            int afterTime = DateTime.UtcNow.Millisecond;
            Console.WriteLine("Time after for loop: {0}", afterTime);
            return pantArr;
        }

        private void SetHeaders()
        {
            
            string authorization = config.Username + ":" + config.Pass;
            byte[] byteAuth = Encoding.UTF8.GetBytes(authorization);
            authorization = Convert.ToBase64String(byteAuth);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authorization);
            
        }
        
    }
}