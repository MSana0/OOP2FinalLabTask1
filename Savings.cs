using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalLabTask1
{
    class Savings:Account
    {
        int wd = 0;
        public Savings(string accName, string accId, double bal):base(accName,accId,bal)
        {

        }
        override public void Withdraw(double amount)
        {
            if(wd>=5)
            {
                Console.WriteLine("Sorry you have already reached maximum transaction limit.");
            }
            else if(this.bal-amount<500)
            {
                Console.WriteLine("Sorry you do not have sufficient balance for the transaction to be completed");
            }
            else
            {
                this.bal = this.bal - amount;
                wd++;
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Account holder name: " + accName + "Account ID: " + accId + "Current account balance: " + Bal);
        }
    }
}
