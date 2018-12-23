using SFML.Graphics;
using SFML.Window;

namespace Dust.Engine
{
    abstract class Scene
    {
        protected DrawableList drawables = new DrawableList();

        abstract public void Init();
        abstract public void Update();
        abstract public DrawableList GetDrawables();
        abstract public void MouseButtonPressed(object sender, MouseButtonEventArgs e);
        abstract public void MouseButtonReleased(object sender, MouseButtonEventArgs e);

    }
}
