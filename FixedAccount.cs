using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalLabTask1
{
    class FixedAccount : Account
    {
        private int temp = 0;
        public int tenureyear = 2;
        private int openDate;

        public int OpenDate
        {
            get { return openDate; }
            set { openDate = value; }
        }
        DateTime date = DateTime.Now;
        public FixedAccount(string accName, string accId, int openDate, double bal) : base(accName, accId, bal)
        {
            this.accName = accName;
            this.accId = accId;
            this.openDate = openDate;
            this.bal = bal;
        }
        override public void Withdraw(double amount)
        {
            int crdate = DateTime.Now.Year;

            if (crdate - this.openDate <= tenureyear)
            {
                Console.WriteLine("Sorry your account has not yet reached the tenure year.");

            }
            else
            {
                if (amount - this.bal > this.bal)
                {
                    Console.WriteLine("Your account doesn't have sufficient balance for the transaction.");
                }
                else
                {
                    this.bal = this.bal - amount;
                    Console.WriteLine("Transaction Executed....");
                }
            }
        }
        override public void ShowInfo()
        {
            Console.WriteLine("Name :" + accName + " ID :" + accId + "  Balance :" + bal);
        }
    }
}