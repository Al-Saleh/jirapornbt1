using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeServiceReference;

namespace AspNetCoreProject.Controllers
{
    [Route("controller")]
    public class PrimeController : Controller
    {
        private PrimesServiceClient  primeServiceClient = new PrimesServiceClient();

        [Route("~/")]
        public IActionResult Index(int PrimeIndex)
        {
            
            PrimeServiceReference.Primes pr = new PrimeServiceReference.Primes();
            if (PrimeIndex > 0)
            {
                pr.Index = PrimeIndex;
                pr.PrimeNumber = primeServiceClient.GetPrimeByIndexAsync(PrimeIndex).Result.PrimeNumber;
            }
                
            return View(pr);
        }
    }
}