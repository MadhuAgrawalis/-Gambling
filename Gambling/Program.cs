using System;

namespace Gambling
{
    public class Gambling

    {
        /*  public void Display()
          {
              int Bet = 1;
              int Money = 100;
              Random bet_num = new Random();
              int check = bet_num.Next(0, 2);
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
          }*/
        public void play()
        {
            int Bet = 1;
            int Money = 100;
            int lose = 0;
            int win = 1;
            int left = 100;
            Random random = new Random();
            int option = random.Next(0, 2);
            while (left > 50 && left < 150)
            {
                switch (option)
                {
                    case lose:
                        left = left - Bet;
                        break;
                    case win:
                        left = left + Bet;
                        break;
                }
            }
            Console.WriteLine("left is " + left);
        }

                public static void Main(string[] args)
{
            Gambling gam = new Gambling();
            gam.play();
}

         }
        
    }

