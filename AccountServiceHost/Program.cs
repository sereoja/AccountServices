using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using AccountsServiceLibrary;


namespace AccountServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1:
            //create a uri to serve as the base address of 
            //this service
            try
            {
                Uri baseAddress =
                    new Uri("http://localhost:13000/AccountExample");
                //step 2:
                //create a servicehost
                ServiceHost selfHost = new ServiceHost(typeof(AccountsServiceLibrary.AccountService), baseAddress);

                //step 3
                selfHost.AddServiceEndpoint(typeof(AccountsServiceLibrary.IAccountService), new BasicHttpBinding(), "AccountsService");

                //step 4 Enable metadata exchange
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                //step 5: set to host to listen
                selfHost.Open();
                Console.WriteLine("\nAccounts Service Host is Listening...");

                Console.ReadLine();//pause
                selfHost.Close();

            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("\n\n" + ce.Message);
            }
        }
    }
}
