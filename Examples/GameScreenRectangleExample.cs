﻿namespace Examples
{
    using System.Drawing;

    using Rage;
    using Rage.Native;
    using Rage.Attributes;
    using Graphics = Rage.Graphics;

    using RAGENativeUI;
    using RAGENativeUI.Menus;
    using RAGENativeUI.Menus.Rendering;
    using RAGENativeUI.Utility;

    internal static class GameScreenRectangleExample
    {
        [ConsoleCommand(Name = "GameScreenRectangleExample", Description = "Example showing GameScreenCoords struct.")]
        private static void Command()
        {
            GameScreenRectangle fromAbsolute = GameScreenRectangle.FromAbsoluteCoords(1920f / 4f, 1080f / 4f, 1920f / 2f, 1080f / 2f);
            GameScreenRectangle fromRelative = GameScreenRectangle.FromRelativeCoords(0.5f, 0.5f, 0.5f, 0.5f);

            Game.LogTrivial("from absolute: " + fromAbsolute);
            Game.LogTrivial("from relative: " + fromRelative);

            float w = 0.5f, h = 0.5f;

            GameFiber.StartNew(() =>
            {
                while (true)
                {
                    GameFiber.Yield();

                    fromRelative = GameScreenRectangle.FromRelativeCoords(0.5f, 0.5f, w, h);

                    if (Game.IsKeyDownRightNow(System.Windows.Forms.Keys.Add))
                    {
                        w += 0.5f * Game.FrameTime;
                        h += 0.5f * Game.FrameTime;
                    }
                    if (Game.IsKeyDownRightNow(System.Windows.Forms.Keys.Subtract))
                    {
                        w -= 0.5f * Game.FrameTime;
                        h -= 0.5f * Game.FrameTime;
                    }
                    
                    NativeFunction.Natives.DrawRect(fromAbsolute.X, fromAbsolute.Y, fromAbsolute.Width, fromAbsolute.Height, 255, 0, 0, 100);
                    
                    NativeFunction.Natives.DrawRect(fromRelative.X, fromRelative.Y, fromRelative.Width, fromRelative.Height, 0, 255, 0, 100);
                }
            });
        }
    }
}