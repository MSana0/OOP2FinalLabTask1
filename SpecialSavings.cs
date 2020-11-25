using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalLabTask1
{
    class SpecialSavings:Account
    {
        int wd = 0;
        public SpecialSavings(string accName,string accId,double bal):base(accName,accId,bal)
        {
            
        }
        override public void Withdraw(double amount)
        {
            double temp = this.bal * 0.2;
            if(trans>=5)
            {
                Console.WriteLine("")
            }
        }
    }
}
