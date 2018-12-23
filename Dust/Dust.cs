using System;
using SFML.Graphics;
using SFML.Window;
using Dust.Engine;
using Dust.Scenes;

namespace Dust
{
    class Dust
    {
        private static RenderWindow window = new RenderWindow(new VideoMode(1024, 576), "Dust", Styles.Titlebar | Styles.Close);
        private static Scene currentScene = null;

        static int count = 0;

        public static int x = 0, y = 0;

        static void Main(string[] args)
        {
            window.Closed += Window_Closed;
            window.MouseButtonPressed += Window_MouseButtonPressed;
            window.MouseButtonReleased += Window_MouseButtonReleased;

            window.SetVerticalSyncEnabled(true);
            window.SetFramerateLimit(60);

            SetScene(new BlankScene());

            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear();

                foreach(Drawable drawable in currentScene.GetDrawables().GetAll())
                {
                    window.Draw(drawable);
                }

                currentScene.Update();
                window.Display();
            }
        }

        public static void SetScene(Scene scene)
        {
            currentScene = scene;
            scene.Init();
        }

        private static void Window_Closed(object sender, EventArgs e)
        {
            window.Close();
        }

        private static void Window_MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            foreach(Drawable drawable in currentScene.GetDrawables().GetAll())
            {
                if(((Text)drawable).GetGlobalBounds().Contains(e.X, e.Y))
                {
                    ((Text)drawable).DisplayedString = "CLICKED! " + (Dust.count++);
                }
            }
        }

        private static void Window_MouseButtonReleased(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
