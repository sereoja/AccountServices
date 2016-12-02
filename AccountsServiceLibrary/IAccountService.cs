using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AccountsServiceLibrary
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        Account GetAccount(int accountNumber);
    }
}
