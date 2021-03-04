using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    class EnemyCharacter:Character
    {
        private int rowMax;
        private int columnMax;
        public EnemyCharacter(int colum, int row, Board board)
            :base(colum, row, board)
        {
            rowMax = board.rowMax;
            columnMax = board.columnMax;
            Texture = Texture2D.LoadStrict(textureResourcePath + "Enemy.png");
            float x = (CellNumber % columnMax) * Texture.Size.X + 200;
            int y = (CellNumber / rowMax) * Texture.Size.Y + 100;
            Position = new Vector2F(x, (float)y);
        }
    }
}
