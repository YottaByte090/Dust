using SFML.Graphics;
using System.Drawing;

namespace Dust.Engine.Utils
{
    class Converter
    {
        public static SFML.Graphics.Image BitmapToImage(Bitmap bitmap)
        {
            SFML.Graphics.Image image = new SFML.Graphics.Image((uint)bitmap.Width, (uint)bitmap.Height);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    System.Drawing.Color systemColor = bitmap.GetPixel(x, y);
                    SFML.Graphics.Color sfmlColor = new SFML.Graphics.Color(systemColor.R, systemColor.G, systemColor.B);
                    image.SetPixel((uint) x, (uint) y, sfmlColor);
                }
            }

            return image;
        }
    }
}
