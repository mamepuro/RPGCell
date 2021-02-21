using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    /// <summary>
    /// キャラやCellに対して操作を行うもの
    /// （例：FEの手のアイコン）
    /// </summary>
    class Player:SpriteNode
    {
        private const string textureRsourcesPath = "Resources/Textures/";
        /// <summary>
        /// Playerが指しているCell番号
        /// </summary>
        public int CellNumber { get; set; }
        /// <summary>
        /// Boardへの参照
        /// </summary>
        private Board board;
        public Player(int cellNum, Board board)
        {
            CellNumber = cellNum;
            this.board = board;
            Texture = Texture2D.LoadStrict(textureRsourcesPath + "playersIcon.png");
            float x = (cellNum % 6) * Texture.Size.X + 200;
            int y = (cellNum / 6) * Texture.Size.Y + 100;
            Position = new Vector2F(x, (float)y);
        }

        private void SelecetCells()
        {
            if (Engine.Keyboard.GetKeyState(Key.D) == ButtonState.Hold || Engine.Keyboard.GetKeyState(Key.Right) == ButtonState.Hold)
            {
                CellNumber++;
                Position += new Vector2F(Texture.Size.X, 0);
            }
            if (Engine.Keyboard.GetKeyState(Key.A) == ButtonState.Hold || Engine.Keyboard.GetKeyState(Key.Left) == ButtonState.Hold)
            {
                CellNumber--;
                Position -= new Vector2F(Texture.Size.X, 0);
            }
            if (Engine.Keyboard.GetKeyState(Key.W) == ButtonState.Hold || Engine.Keyboard.GetKeyState(Key.Up) == ButtonState.Hold)
            {
                CellNumber -= 6;
                Position -= new Vector2F(0, Texture.Size.Y);
            }
            if (Engine.Keyboard.GetKeyState(Key.S) == ButtonState.Hold || Engine.Keyboard.GetKeyState(Key.Down) == ButtonState.Hold)
            {
                CellNumber += 6;
                Position += new Vector2F(0, Texture.Size.Y);
            }
        }
        protected override void OnUpdate()
        {
            SelecetCells();
            base.OnUpdate();
        }
    }
}
