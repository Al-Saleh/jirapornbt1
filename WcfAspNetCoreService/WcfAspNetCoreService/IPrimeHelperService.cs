using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfAspNetCoreService
{
    [ServiceContract]
    public interface IPrimeHelperService
    {
        [OperationContract]
        bool IsPrimeNumber(int Number);

        [OperationContract]
        int GetPrimeNumberByIndex(int pIndex);
    }
}
