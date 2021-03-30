using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    class Human
    {
        public string Name { get; set; }
        public int WinCount { get; set; }
        public bool WannaPlay { get; set; }

        public int Guess { get; set; }
        public void play()
        {
            string game = Console.ReadLine();
            game.ToLower();
            if (game == "y") { this.WannaPlay = true; }
            else if (game == "n") { this.WannaPlay = false; }
            else { 
                Console.WriteLine("invalid character; insert Y or N");
                this.play();
            }

        
        }
        public void guess()
        {
            string gett = Console.ReadLine();
            try
            {
                this.Guess = int.Parse(gett);
            }
            catch (Exception e)
            {
                Console.WriteLine("You must enter number");
                this.guess();
            }
            

        }
        
    }
}
