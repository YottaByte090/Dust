using System;
using SFML.Graphics;
using SFML.Window;
using Dust.Engine;

namespace Dust
{
    enum PixelType
    {
        None,
        Powder,
        Block
    }

    class Dust
    {
        private static RenderWindow window = new RenderWindow(new VideoMode(1024, 576), "Dust", Styles.Titlebar | Styles.Close);
        private static Scene currentScene = new MainScene();
        public static PixelType[,] data = new PixelType[1024, 576];

        private static PixelType drawState = PixelType.None;

        private static bool isAlive = true;
        public static int x = 0, y = 0;

        static void Main(string[] args)
        {
            window.Closed += Event_Closed;
            window.TextEntered += Event_TextEntered;
            window.MouseMoved += Event_MouseMoved;
            window.MouseButtonPressed += Event_MouseButtonPressed;
            window.MouseButtonReleased += Event_MouseButtonReleased;

            window.SetVerticalSyncEnabled(true);
            window.SetFramerateLimit(60);

            currentScene.Init();

            while (isAlive)
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

        static void Event_Closed(object sender, EventArgs e)
        {
            isAlive = false;
            window.Close();
        }

        static void Event_TextEntered(object sender, TextEventArgs e)
        {
            
        }

        static void Event_MouseMoved(object sender, MouseMoveEventArgs e)
        {
            x = e.X;
            y = e.Y;

            if (data[x, y] == PixelType.None && drawState != PixelType.None) data[x, y] = drawState;
        }

        static void Event_MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            switch (e.Button)
            {
                case Mouse.Button.Left:
                    drawState = PixelType.Powder;
                    if (data[x, y] == PixelType.None) data[x, y] = PixelType.Powder;
                    break;
                case Mouse.Button.Right:
                    drawState = PixelType.Block;
                    if (data[x, y] == PixelType.None) data[x, y] = PixelType.Block;
                    break;
            }
        }

        static void Event_MouseButtonReleased(object sender, MouseButtonEventArgs e)
        {
            drawState = PixelType.None;
        }
    }
}
