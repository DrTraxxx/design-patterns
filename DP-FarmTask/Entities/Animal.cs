using DP_FarmTask.State;
using DP_FarmTask.Contracts;
using DP_FarmTask.AnimalManager;
using System.Collections.Generic;
using System;

namespace DP_FarmTask.Entities
{
    public class Animal:IObservable
    {
        protected AnimalState state;

        public Animal(AnimalState state , AnimalType type)
        {
            this.OnChange(state);
            Type = type;
        } 
    
        public AnimalType Type { get; set; }
        protected List<IObserver> observers => new List<IObserver>{ new AnimalObserver()};

        public virtual void OnChange(AnimalState state)
        {
            this.state = state;
            this.state.SetState(this);
            
        }

        public virtual void DisplayCurrentState()
        {
            state.DisplayState();
        } 

        public virtual void ChangeActivity()
        {
            this.state.Handle();
        }

        public virtual void Nofity()
        {
            Console.WriteLine("Notification send!");

            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}