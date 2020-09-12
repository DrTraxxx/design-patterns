using System;
using DP_FarmTask.Contracts;

namespace DP_FarmTask.AnimalManager
{
    public class AnimalObserver : IObserver
    {
        public void Update(IObservable subject)
        {
            Console.WriteLine($"{subject.GetType()} state has changed");
        }
    }

}