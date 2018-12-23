using SFML.Graphics;

namespace Dust
{
    abstract class Scene
    {
        private DrawableList drawables = new DrawableList();

        abstract public void Init();
        abstract public void Update();
        abstract public DrawableList GetDrawables();
    }
}
