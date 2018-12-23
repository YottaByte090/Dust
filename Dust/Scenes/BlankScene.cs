using SFML.Graphics;
using SFML.Window;
using Dust.Engine;
using Dust.Engine.GUI;

namespace Dust.Scenes
{
    class BlankScene : Scene
    {
        Label label = new Label();

        public override void Init()
        {
            label.Text = "wasted";
            label.TextSize = 50;
            label.TextColor = Color.Red;
            label.TextStyle = Text.Styles.Italic;
            label.Position = new SFML.System.Vector2f(50.0f, 50.0f);

            drawables.Add("label1", label.GetDrawable());
        }

        private void Pressed(object sender, MouseButtonEventArgs e)
        {
            label.Text = "Label Pressed";
        }

        public override void Update()
        {
            
        }

        public override DrawableList GetDrawables()
        {
            return drawables;
        }

        public override void MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            foreach(Drawable drawable in drawables.GetAll())
            {
                if (drawable.GetType() == typeof(Text))
                {

                }
            }
        }

        public override void MouseButtonReleased(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
