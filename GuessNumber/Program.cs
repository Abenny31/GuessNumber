using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Machine machine = new Machine();

            machine.hello();
            human.Name = Console.ReadLine();
            Console.WriteLine($"How about a game {human.Name}?");
            Console.WriteLine("I will think* about a number between 0 and 5 and you guess?");
            Console.Write("If you wanna play write Y and if you dont write N and pres ENTER: ");
            human.play();
            while (human.WannaPlay == true)
            {
                Console.WriteLine("\n\nCan you guess the number I'm thinkinkg of? \nWrite it down: ");
                machine.Getrandom();
                human.guess();
                Console.WriteLine("");
                if (machine.rand == human.Guess)
                {
                    human.WinCount += 1;
                    Console.WriteLine("You win");
                    Console.WriteLine("You have " + human.WinCount + " wins!");
                }
                else
                {
                    machine.WinCount += 1;
                    Console.WriteLine("You loose");
                    Console.WriteLine("Number was: "+machine.rand);
                    Console.WriteLine("Score is \n Machine: " + machine.WinCount + " Human: " + human.WinCount);
                }

                Console.WriteLine("Do you wanna play again? (Y/N)\n\n");
                human.play();

            }

            Goodbye(machine, human);



            Console.ReadKey();

            static void Goodbye(Machine a, Human b)
            {
                Console.WriteLine("Final score is: \nMachine: " + a.WinCount + " Human: " + b.WinCount);
                if (a.WinCount > b.WinCount) { Console.WriteLine("You looose suckeeer!!! \nSeeYa next time"); }
                else { Console.WriteLine("Congrats, YOU WIN!!!"); }
                Console.WriteLine("Press any key to exit");
            }

        }
    }
}
