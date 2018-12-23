using SFML.Graphics;

namespace Dust.Engine
{
    abstract class Scene
    {
        protected DrawableList drawables = new DrawableList();

        abstract public void Init();
        abstract public void Update();
        abstract public DrawableList GetDrawables();
    }
}
