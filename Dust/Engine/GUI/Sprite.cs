using SFML.Graphics;
using Dust.Engine.Utils;

namespace Dust.Engine.GUI
{
    class Sprite : GUI
    {
        private static Texture texture = new Texture(Converter.BitmapToImage(Resource.NO_IMAGE));
        private RectangleShape rectangle = new RectangleShape();

        public Sprite()
        {
            rectangle.Texture = texture;
        }

        public override Drawable GetDrawable()
        {
            return rectangle;
        }
    }
}
