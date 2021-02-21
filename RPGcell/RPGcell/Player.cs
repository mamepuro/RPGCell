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
        public int CellNumber { get; set; }
        /// <summary>
        /// Boardへの参照
        /// </summary>
        private Board board;

        public Player()
        {

        }
    }
}
