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
        public ObjectsOnCell ObjectOnThisCell { get; set; }
        /// <summary>
        /// Cellの状態を保存する
        /// </summary>
        public CellStatus CellStatus { get; set; }
        public Cell(int column, int row, int rowMax, int columnMax)
        {
            CellNumber = row * columnMax + column;
            Texture = Texture2D.LoadStrict("Resources/Textures/cell.png");
            float x = (column) * Texture.Size.X + 200;
            int y = (row) * Texture.Size.Y + 100;
            Position = new Vector2F(x, (float)y);
            ObjectOnThisCell = null;
        }

        /// <summary>
        /// このCellにオブジェクトを登録する
        /// </summary>
        /// <param name="obj">Cellに追加するオブジェクト</param>
        public void AddObject(ObjectsOnCell obj)
        {
            ObjectOnThisCell = obj;
        }

        /// <summary>
        /// このCellのオブジェクトを取り除く
        /// </summary>
        public void RemoveObject()
        {
            ObjectOnThisCell = null;
        }
    }
}
