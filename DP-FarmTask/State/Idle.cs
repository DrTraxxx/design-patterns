using System;
using DP_FarmTask.Contracts;
using DP_FarmTask.Entities;

namespace DP_FarmTask.State
{
    public class Idle : AnimalState
    {
        public override Activity Activity  => Activity.Idle;
        public override void DisplayState()
        {
            Console.WriteLine($"{animal.Type} is now idle");
        }

        public override void Handle()
        {
            animal.OnChange(new Eating());
        }
    }
}