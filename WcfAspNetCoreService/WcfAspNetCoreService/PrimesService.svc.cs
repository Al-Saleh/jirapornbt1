
namespace WcfAspNetCoreService
{
    public class PrimesService : IPrimesService
    {
        public Primes GetPrimeByIndex(int index)
        {
            PrimeHelperService helpService = new PrimeHelperService();
            int Value = helpService.GetPrimeNumberByIndex(index);

            return new Primes { Index = index, PrimeNumber = Value };
        }
    }
}
