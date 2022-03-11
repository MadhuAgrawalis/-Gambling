using System;

namespace Gambling
{
    public class Gambling

    {
        public void Display()
        {
            int Bet = 1;
            int Money = 100;
            Random bet_num = new Random();
            int check = bet_num.Next(0, 100);
            Console.WriteLine("Started ");
            Console.WriteLine("check");

        
        if (Bet == check)
            {
            Console.WriteLine("you Win");
            }
          else 
           {
            Console.WriteLine("Loss");
            }
        }

        public static void Main(string[] args)
{
            Gambling gam = new Gambling();
            gam.Display();
}

         }
        
    }

