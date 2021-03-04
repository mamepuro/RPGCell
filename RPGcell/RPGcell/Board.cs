using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    /// <summary>
    /// Cellを6*6で持つ戦場
    /// </summary>
    class Board:SpriteNode
    {
        private const string textureResourcesPath = "Resources/Textures/";
        /// <summary>
        /// boardに存在するcellの行数
        /// </summary>
        public int rowMax = 7;
        /// <summary>
        /// boardに存在するcellの
        /// </summary>
        public int columnMax = 6;
        /// <summary>
        /// board上のcellの集合
        /// </summary>
        public List<Cell> Cells { get; set; }
        /// <summary>
        /// 選択中のCell番号
        /// </summary>
        public int CelectingCellNumber { get; set; }
        public Board()
        {
            Cells = new List<Cell>();
            for(int row = 0; row < rowMax; row++)
            {
                for(int column = 0; column < columnMax; column++)
                {
                    var cell = new Cell(column, row, rowMax, columnMax);
                    Cells.Add(cell);
                    Engine.AddNode(cell);
                }
            }
            var player = new Player(0, this);
            Engine.AddNode(player);
            PlayerCharacter playerCharacter = new PlayerCharacter(0, 0, this);
            Engine.AddNode(playerCharacter);
            Cells[0].AddObject(playerCharacter);
            var enemy = new EnemyCharacter(4, 3, this);
            Engine.AddNode(enemy);
            Cells[26].AddObject(enemy);
        }

        protected override void OnUpdate()
        {
            base.OnUpdate();
        }
    }
}
