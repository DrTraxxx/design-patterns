using DP_FarmTask.Contracts;
using DP_FarmTask.State;

namespace DP_FarmTask.Entities
{
    public class Horse : Animal
    {
        public Horse(AnimalState state, AnimalType type) : base(state, type)
        {
        }

        public override void DisplayCurrentState()
        {
            base.DisplayCurrentState();
        }
        
        public override void OnChange(AnimalState state)
        {
            base.OnChange(state);

            if(state.Activity == Activity.Eating)
                this.Nofity();

        }

        public override void Nofity()
        {
            base.Nofity();
        }
    }
}