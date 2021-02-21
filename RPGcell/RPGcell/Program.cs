using System;
using System.Collections.Generic;
using Altseed2;

namespace RPGcell
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine.Initialize("CellHero", 1260, 720);
            Console.WriteLine("Hello World!");
            //Sound se;
            //se = Sound.LoadStrict("Resorces/Sounds/se_pyuun.mp3", true);

            // 音を再生します。
            Board board = new Board();
            Engine.AddNode(board);
            while (Engine.DoEvents())
            {
                Engine.Update();
                if(Engine.Keyboard.GetKeyState(Key.Escape) == ButtonState.Push)
                {
                    break;
                }
                //Engine.Sound.Play(se);
            }
            Engine.Terminate();
        }
    }
}
