using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    /// <summary>
    /// Cell上に存在するオブジェクト全般の親クラス
    /// 列や行番号の情報をメンバとして持つ
    /// </summary>
    class ObjectsOnCell:SpriteNode
    {
        /// <summary>
        /// テクスチャリースディレクトリまでのパス
        /// </summary>
        protected const string textureResourcePath = "Resources/Textures/";
        /// <summary>
        /// 何番目のCell上に存在するかを保持する
        /// </summary>
        public int CellNumber { get; set; }
        /// <summary>
        /// 何列目に存在するかを保存する
        /// </summary>
        protected int Column { get; set; }
        /// <summary>
        /// 何行目に存在するかを保存する
        /// </summary>
        protected int Row { get; set; }

        public ObjectsOnCell(int column, int row)
        {
            Column = column;
            Row = row;
            CellNumber = row * 6 + column;
        }
    }
}
