using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_AccountsService.ServiceReference1;

namespace Client_AccountsService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountServiceClient asc = new AccountServiceClient();
            int accountNumber = int.Parse(txtAccountNumber.Text);
            Account account = asc.GetAccount(accountNumber);
            if (account != null)
                richTextBox1.Text =
                  "account number: " + account.AccountNumber + "\n" +
                  "current balance: " + account.Balance.ToString("c") + "\n" +
                  "bank: " + account.Bank;
            else
                richTextBox1.Text =
                    "No such account exists";
        }
    }
}
