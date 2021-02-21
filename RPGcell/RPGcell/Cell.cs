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
        /// このCell上にあるオブジェクトを保管する
        /// </summary>
        public object ObjectOnThisCell { get; set; }
        /// <summary>
        /// Cellの状態を保存する
        /// </summary>
        public CellStatus CellStatus { get; set; }
        public Cell(int cellNum)
        {
            CellNumber = cellNum;
            Texture = Texture2D.LoadStrict("Resources/Textures/cell.png");
            float x = (cellNum % 6) * Texture.Size.X + 200;
            int y = (cellNum / 6) * Texture.Size.Y + 100;
            Position = new Vector2F(x, (float)y);
        }
    }
}
