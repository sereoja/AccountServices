using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsServiceLibrary
{
    public class AccountsDatabase
    {
        //simulating a database of accounts
        internal static List<Account> accounts =
            new List<Account> {
                new Account {AccountNumber=1234567,Balance=1200,Bank="Bank of America" },
                new Account{AccountNumber=2345678,Balance=0975,Bank="Chase Bank" },
                new Account{AccountNumber=3456789,Balance=2589.95m,Bank="Columbia Bank" },
                new Account{AccountNumber=2134567,Balance=6598.77m,Bank="HomeStreet Bank" },
                new Account{AccountNumber=3216547,Balance=988.60m,Bank="Credit Union Bank" }

            };
    }
}
