using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    class Cell:SpriteNode
    {
        /// <summary>
        /// 何番目のCellなのかを保持する
        /// </summary>
        public int CellNumber { get; set; }
        /// <summary>
        /// Cellが何列目に存在するかを保存する
        /// </summary>
        private int Column { get; set; }
        /// <summary>
        /// Cellが何行目に存在するかを保存する
        /// </summary>
        private int Row { get; set; } 
        /// <summary>
        /// このCell上にあるオブジェクトを保管する
        /// </summary>
        public Character ObjectOnThisCell { get; set; }
        /// <summary>
        /// Cellの状態を保存する
        /// </summary>
        public CellStatus CellStatus { get; set; }
        public Cell(int column, int row)
        {
            CellNumber = row * 6 + column;
            Texture = Texture2D.LoadStrict("Resources/Textures/cell.png");
            float x = (CellNumber % 6) * Texture.Size.X + 200;
            int y = (CellNumber / 6) * Texture.Size.Y + 100;
            Position = new Vector2F(x, (float)y);
        }
    }
}
