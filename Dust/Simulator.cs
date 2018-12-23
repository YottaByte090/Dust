using Dust.Engine;

namespace Dust
{
    class Simulator
    {
        abstract class Component
        {
            public abstract void Simulate();
        }
        class Gravity : Component
        {
            public Gravity(ref DrawableList d)
            {

            }
            public override void Simulate()
            {
                
            }
        }
    }
}
