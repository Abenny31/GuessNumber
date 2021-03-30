using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    class Machine
    {
        public int rand { get; set; }
        public int WinCount { get; set; }
        public void hello()
        {
            Console.WriteLine("Hello Human");
            Console.Write("Tell me your name: ");
        }
        public void  Getrandom()
        {
            Random r = new Random();
            this.rand  = r.Next(0, 5);
            
        }
    }
}
