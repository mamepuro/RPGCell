﻿using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    /// <summary>
    /// Cell上に乗っかるキャラクター
    /// Playerによって操作されるコマのような存在
    /// </summary>
    class Character:SpriteNode
    {
        /// <summary>
        /// キャラクターのHP
        /// </summary>
        public int HP { get; set; }
        /// <summary>
        /// ターン中に行動できる回数
        /// </summary>
        public int ActionLimit { get; set; }
        public Character()
        {

        }
        protected override void OnAdded()
        {
            base.OnAdded();
        }
    }
}