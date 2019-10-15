using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
   public class Account
    {
       private int n;
       public Account(int amount)
       {
            n = amount;

       }
       public void deposit(int amount)
       {
           n = n + amount;
       }
       public void Withdraw(int amount)
       {
           n = n - amount;
       }
       public int Balance()
       {
          
           return n;
       }
    }
}
