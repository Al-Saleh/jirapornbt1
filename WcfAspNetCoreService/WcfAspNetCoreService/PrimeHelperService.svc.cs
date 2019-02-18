using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfAspNetCoreService
{
    public class PrimeHelperService : IPrimeHelperService
    {
        public bool IsPrimeNumber(int Number)
        {
            if (Number > 1)
            {
                return Enumerable.Range(1, Number).Where(x => Number % x == 0)
                                 .SequenceEqual(new[] { 1, Number });
            }

            return false;
        }

        public int GetPrimeNumberByIndex(int pIndex)
        {
            int primeNumber = 0;
            int Number = 2, fPrime = 0;
            while (primeNumber == 0)
            {
                if (IsPrimeNumber(Number))
                {
                    fPrime++;
                    if (pIndex == fPrime)
                        primeNumber = Number;
                }
                Number++;
            }
            return primeNumber;
        }

    }
}
