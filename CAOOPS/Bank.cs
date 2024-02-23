using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAOOPS
{
       class Bank
    {
        public double balance;
        public void Deposit()
        {
            Console.WriteLine("Enter an amount to deposit");
            double amt = Convert.ToDouble(Console.ReadLine());
            balance = amt;
            Console.WriteLine("The balance is "+balance);
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter an amount to withdraw");
            double wdamt = Convert.ToDouble(Console.ReadLine());
                if(wdamt > balance) 
                {
                Console.WriteLine("Insufficient Funds Enter an amount less than balance");
                double wdamt1 = Convert.ToDouble(Console.ReadLine());
                balance = balance - wdamt1;
                Console.WriteLine("balance is :" + balance);
            }
                else
                {
                balance = balance - wdamt;
                Console.WriteLine("balance is :" + balance);
                    }
        }
    }
}
