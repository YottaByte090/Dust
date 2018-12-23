using SFML.Graphics;
using System.Collections.Generic;

namespace Dust.Engine
{
    class DrawableList
    {
        private Dictionary<string, int> ids = new Dictionary<string, int>();
        private List<Drawable> drawables = new List<Drawable>();

        public void Add(string name, Drawable drawable)
        {
            ids.Add(name, drawables.Count);
            drawables.Add(drawable);
        }

        public Drawable Get(string name)
        {
            if (ids.ContainsKey(name))
            {
                return drawables[ids[name]];
            }
            else
            {
                return null;
            }
        }

        public Drawable[] GetAll()
        {
            return drawables.ToArray();
        }
    }
}
