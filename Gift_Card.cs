using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift_Card
{
   class Program
    {
        static void Main(string[] args)
        {
            Gift_Card gift = new Gift_Card(4000,true);
            gift.rechargeCard(2000);
            gift.swipeCard(400);
            gift.swipeCard(500);

            Console.WriteLine("************************************");
            Console.WriteLine(" \n ");
            Gift_Card gi = new Gift_Card();
            gi.rechargeCard(3000);
            gi.swipeCard(500);
            gi.swipeCard(2600);
            Console.WriteLine();
            Console.ReadKey();

        }

        public class Gift_Card
        {
            private long cardNo;//private instances
            private double balance;
            private Boolean active;

            public long CardNo //properties ,parametrized Constructor to initialize variables
            {
                get { return cardNo; } //get method returns the value of the variable 
                set { cardNo = value; } //set method assigns a value to the variable
            }

            public double Balance
            {
                get { return balance; }
                set { balance = value; }

            }

            public Boolean Active
            {
                get { return active; }
                set { active = value; }
            }

            public Gift_Card(long no, Boolean Active)
            {
                this.cardNo = no;
                this.active = Active;
            }

            public Gift_Card()
            {
                this.balance = 0;
                this.active = true;
            }

            public void rechargeCard(double amount)
            {
                if (active == true)

                {
                    amount = balance + amount;
                    Console.WriteLine("Active cards can be recharged");
                }
                else
                {
                    Console.WriteLine("Account is inactive");
                }
            }

            public void swipeCard(double amount)
            {
                if (active == true && balance > amount)
                {
                    balance = balance - amount;
                    Console.WriteLine("available balance is {0}", balance);
                }
                else
                {
                    Console.WriteLine("available balance is insufficient");
                }
            }

        }

}

}
