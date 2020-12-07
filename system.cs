using using System;

namespace bankapp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Account a0 = new Savings();
           
            Account a1 = new Savings("Hamim Hasan", 112233, 10000);

            SpecialSavings s1 = new SpecialSavings(20);
            
            Account a2 = new SpecialSavings("Arman Rahman", 445566, 20000, 20);

            Account a3 = new Fixed("Hamim Hasan", 813444, 8000);

            Account a4 = new Overdraft (1000);
            
            Overdraft od1 = new Overdraft("Hamim Hasan", 658233, 12066, 4000);
        }
    }
}