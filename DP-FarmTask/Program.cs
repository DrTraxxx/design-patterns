using System;
using DP_FarmTask.AnimalManager;
using DP_FarmTask.Contracts;
using DP_FarmTask.Entities;
using DP_FarmTask.State;

namespace DP_FarmTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Horse = new Horse(new Idle(),AnimalType.Horse);
            Animal Cow = new Cow(new Idle(),AnimalType.Cow); 
           
            Console.WriteLine("Starting Simulation"); 
            Console.Write("\nPress 'Enter' to exit ");
            int iterator = 0;

            //Console.ReadKey(true).Key != ConsoleKey.Enter not working on Linux :(
            while(iterator<10)
            {
                Horse.DisplayCurrentState();
                Horse.ChangeActivity();

                Cow.DisplayCurrentState();
                Cow.ChangeActivity();

                iterator++;
            }
        }
    }
}
