using System;
using DP_FarmTask.Contracts;
using DP_FarmTask.Entities;

namespace DP_FarmTask.State
{
    public class Eating : AnimalState
    {
        public override Activity Activity  => Activity.Eating;
        public override void DisplayState()
        {
            Console.WriteLine($"{animal.Type} is now eating");
        }

        public override void Handle()
        {
            animal.OnChange(new Sleeping());
        }
    }
}