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

        public static int x = 0, y = 0;

        static void Main(string[] args)
        {
            window.Closed += Window_Closed;

            window.SetVerticalSyncEnabled(true);
            window.SetFramerateLimit(60);

            SetScene(new BlankScene());

            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear();

                currentScene.Update();

                foreach (Drawable drawable in currentScene.GetDrawables().GetAll())
                {
                    window.Draw(drawable);
                }

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
    }
}
