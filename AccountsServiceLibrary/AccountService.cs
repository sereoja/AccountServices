using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsServiceLibrary
{
    public class AccountService : IAccountService
    {
        public Account GetAccount(int accountNumber)
        {
            //get the account object with the specified accountNumber
            Account account = AccountsDatabase.accounts.Find(
                a => a.AccountNumber == accountNumber);

            return account;
        }
    }
}
