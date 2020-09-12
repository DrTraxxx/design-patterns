using DP_FarmTask.Contracts;
using DP_FarmTask.State;

namespace DP_FarmTask.Entities
{
    public class Cow : Animal 
    {
        public Cow(AnimalState state, AnimalType type) : base(state, type)
        {
        }

        public override void OnChange(AnimalState state)
        {
            base.OnChange(state);
        }

        public override  void DisplayCurrentState()
        {
            base.DisplayCurrentState();
        }

    }
}