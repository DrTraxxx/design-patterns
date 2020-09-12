using DP_FarmTask.Contracts;
using DP_FarmTask.Entities;

namespace DP_FarmTask.State
{
    public abstract class AnimalState
    {
        protected Animal animal;

        public void SetState(Animal animal)
         {
             this.animal = animal;
         } 
          
         public virtual Activity Activity { get; set; }

         public abstract void DisplayState(); 

         public abstract void Handle();
    }
}