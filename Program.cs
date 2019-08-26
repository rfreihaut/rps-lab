using System;

namespace RPSBreakout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RPSEnum.Rock);
            Rocky r = new Rocky("Rock");
            Human h = new Human("Dywane Johnson");

            

            Random rando = new Random();
            Random randy = new Random();

            RandomPlayer rp = new RandomPlayer("Bob", randy);
            for (int i = 0; i < 100; i++)
            {
                 
                Console.WriteLine(rp.GetRPS());
            }
        }
    }
}
