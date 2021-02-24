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
        ///Playerが何行目にいるかを保存する(最初値は0)
        /// </summary>
        private int Row { get; set; }
        /// <summary>
        /// Playerが何列目にいるかを保存する(最小値は0)
        /// </summary>
        private int Column { get; set; }
        /// <summary>
        /// Boardへの参照
        /// </summary>
        private Board board;
        public Player(int cellNum, Board board)
        {
            CellNumber = cellNum;
            Row = 0;
            Column = 0;
            this.board = board;
            Texture = Texture2D.LoadStrict(textureRsourcesPath + "playersIcon.png");
            float x = (cellNum % 6) * Texture.Size.X + 200;
            int y = (cellNum / 6) * Texture.Size.Y + 100;
            Position = new Vector2F(x, (float)y);
        }

        private int CheckRow(int row)
        {
            var r = row;
            r = MathHelper.Clamp(r, 5, 0);
            return r;
        }

        private int CheckColumn(int column)
        {
            var c = column;
            c = MathHelper.Clamp(c, 5, 0);
            return c;
        }
        private void SelecetCells()
        {
            var x = Position.X;
            var y = Position.Y;
            if (Engine.Keyboard.GetKeyState(Key.D) == ButtonState.Push || Engine.Keyboard.GetKeyState(Key.Right) == ButtonState.Push)
            {
                Column++;
                Column = CheckColumn(Column);
                x += Texture.Size.X;
            }
            if (Engine.Keyboard.GetKeyState(Key.A) == ButtonState.Push || Engine.Keyboard.GetKeyState(Key.Left) == ButtonState.Push)
            {
                Column--;
                Column = CheckColumn(Column);
                x -= Texture.Size.X;
            }
            if (Engine.Keyboard.GetKeyState(Key.W) == ButtonState.Push || Engine.Keyboard.GetKeyState(Key.Up) == ButtonState.Push)
            {
                Row--;
                Row = CheckRow(Row);
                y -= Texture.Size.Y;
            }
            if (Engine.Keyboard.GetKeyState(Key.S) == ButtonState.Push || Engine.Keyboard.GetKeyState(Key.Down) == ButtonState.Push)
            {
                Row++;
                Row = CheckRow(Row);
                y += Texture.Size.Y;
            }
            x = MathHelper.Clamp(x, Texture.Size.X * 5 + 200, 200);
            y = MathHelper.Clamp(y, Texture.Size.Y * 5 + 100, 100);
            CellNumber = Row * 6 + Column;
            Console.WriteLine(CellNumber);
            Position = new Vector2F(x, y);
        }
        protected override void OnUpdate()
        {
            SelecetCells();
            base.OnUpdate();
        }
    }
}
