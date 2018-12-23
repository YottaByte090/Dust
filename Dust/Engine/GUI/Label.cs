using SFML.Graphics;
using SFML.System;

namespace Dust.Engine.GUI
{
    class Label : GUI
    {
        private static Font font = new Font("Font.ttf");
        private Text text = new Text();

        public Label()
        {
            text.Font = font;
        }

        public string Text
        {
            get
            {
                return text.DisplayedString;
            }
            set
            {
                text.DisplayedString = value;
            }
        }

        public Font TextFont
        {
            get
            {
                return font;
            }
            set
            {
                font = value;
            }
        }

        public uint TextSize
        {
            get
            {
                return text.CharacterSize;
            }
            set
            {
                text.CharacterSize = value;
            }
        }

        public Color TextColor
        {
            get
            {
                return text.FillColor;
            } 
            set
            {
                text.FillColor = value;
            }
        }

        public Text.Styles TextStyle
        {
            get
            {
                return text.Style;
            }
            set
            {
                text.Style = value;
            }
        }

        public Vector2f Position
        {
            get
            {
                return text.Position;
            }

            set
            {
                text.Position = value;
            }
        }

        public float Rotation
        {
            get
            {
                return text.Rotation;
            }
            set
            {
                text.Rotation = value;
            }
        }



        public override Drawable GetDrawable()
        {
            return text;
        }
    }
}
