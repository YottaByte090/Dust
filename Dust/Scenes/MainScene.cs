using System;
using SFML.Graphics;
using SFML.System;
using Dust.Engine;

namespace Dust
{
    class MainScene : Scene
    {
        private DrawableList drawables = new DrawableList();
        private static Font font = new Font("Font.ttf");

        private static Text label1;
        private static Image image;
        private static Texture texture;
        private static Sprite foo;

        public override void Init()
        {
            label1 = new Text();
            label1.Font = font;
            label1.CharacterSize = 16;
            label1.FillColor = Color.White;
            label1.Position = new Vector2f(10.0f, 10.0f);

            image = new Image(1024, 576);
            texture = new Texture(1024, 576);
            foo = new Sprite(texture);

            drawables.Add("foo", foo);
            drawables.Add("label1", label1);
        }

        public override void Update()
        {
            ((Text)drawables.Get("label1")).DisplayedString = string.Format("Dust (ALPHA 0.0.1)\nX : {0}\nY : {1}\n\n좌클릭 : 모래\n우클릭 : 돌", Dust.x, Dust.y);

            for(int x=0; x<1024; x++)
            {
                for(int y=0; y<576; y++)
                {
                    Color color = Color.Black;
                    if (Dust.data[x, y] == PixelType.Block) color = Color.White;
                    if (Dust.data[x, y] == PixelType.Powder) color = Color.Green;
                    image.SetPixel((uint)x, (uint)y, color);
                }
            }

            texture.Update(image);
        }

        public override DrawableList GetDrawables()
        {
            return drawables;
        }
    }
}
