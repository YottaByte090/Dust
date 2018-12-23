using System;
using SFML.Graphics;
using SFML.Window;

namespace Dust.Engine.GUI
{
    abstract class GUI
    {
        public abstract Drawable GetDrawable();
    }
}
