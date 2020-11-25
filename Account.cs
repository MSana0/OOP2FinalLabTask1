using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalLabTask1
{
    abstract class Account
    {
        private string accName;
        public string AccName
        { get { return accName; } set { accName = value; } }
        private string accId;
        public string AccId
        { get { return accId; } set { accId = value; } }
        private double bal;
        public double Bal
        { get { return bal; } set { bal = value; } }
        public Account(string accName, string accId, double bal)
        {
            this.accName = accName;
            this.accId = accId;
            this.bal = bal;
        }
        public void Deposit(double amount)
        {
            bal += amount;
        }
        abstract public void ShowInfo();
        abstract public void Withdraw();
    }
}
