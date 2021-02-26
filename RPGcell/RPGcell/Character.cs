using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    /// <summary>
    /// Cell上に乗っかるキャラクター
    /// Playerによって操作されるコマのような存在
    /// </summary>
    class Character:ObjectsOnCell
    {
        /// <summary>
        /// キャラクターのHP
        /// </summary>
        public int HP { get; set; }
        /// <summary>
        /// ターン中に行動できる回数
        /// </summary>
        public int ActionLimit { get; set; }
        public Character(int column, int row, Board board)
            :base(column, row, board)
        {
        }
        protected override void OnAdded()
        {
            base.OnAdded();
        }
    }
}
