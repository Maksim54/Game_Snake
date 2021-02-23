using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Snakes
{
    public class Start
    {
        public ConsoleKeyInfo key;
        public Start()
        {

        }
        int valik = 0;
        public int choice()
        {
            Console.WriteLine("Start game - Enter\nStop game - Esc");
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
            {
                valik = 1;
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                valik = 2;
            }
            return valik;
        }

        public void Game_stop()
        {
            Console.Clear();
            Console.WriteLine("Exit");
            Console.Beep();

        }
    }
}
