using System;
using DP_FarmTask.Contracts;
using DP_FarmTask.Entities;

namespace DP_FarmTask.State
{
    public class Sleeping : AnimalState
    {
        public override Activity Activity  => Activity.Sleeping;

        public override void DisplayState()
        {
            Console.WriteLine($"{animal.Type} is now sleeping");
        }

        public override void Handle()
        {
            animal.OnChange(new Idle());
        }
    }
}