using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfAspNetCoreService
{
    [ServiceContract]
    public interface IPrimesService
    {
        [OperationContract]
        Primes GetPrimeByIndex(int index);
    }
}
