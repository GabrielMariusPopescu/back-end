using System;

namespace SoftwareDevelopmentSkillsAssessments
{
    public class Coin
    {
        public void Change(double origAmount, int[] coins)
        {
            double remainAmount;
            if (origAmount % QUARTER < origAmount)
            {
                coins[3] = (int)(origAmount / QUARTER);
                remainAmount = origAmount % QUARTER;
                origAmount = remainAmount;
            }
            if ((origAmount % DIME) < origAmount)
            {
                coins[2] = (int)(origAmount / DIME);
                remainAmount = origAmount % DIME;
                origAmount = remainAmount;
            }
            if ((origAmount % PENCE) < origAmount)
            {
                coins[1] = (int)(origAmount / PENCE);
                remainAmount = origAmount % PENCE;
                origAmount = remainAmount;
            }
            if ((origAmount % PENNY) < origAmount)
            {
                coins[0] = (int)(origAmount / PENNY);
                remainAmount = origAmount % PENNY;
                origAmount = remainAmount;
            }
        }

        public void Show(int[] coins)
        {
            if (coins[3] > 0)
                Console.WriteLine("Number of quarters: " + coins[3] + " x " + QUARTER);
            if (coins[2] > 0)
                Console.WriteLine("Number of dimes: " + coins[2] + " x " + DIME);
            if (coins[1] > 0)
                Console.WriteLine("Number of nickels: " + coins[1] + " x " + PENCE);
            if (coins[0] > 0)
                Console.WriteLine("Number of pennies: " + coins[0] + " x " + PENNY);
        }

        //

        private const double QUARTER = 0.25;
        private const double DIME = 0.10;
        private const double PENCE = 0.05;
        private const double PENNY = 0.01;
    }
}
