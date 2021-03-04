using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    class PlayerCharacter:Character
    {
        private int rowMax;
        private int columnMax;
        public PlayerCharacter(int column, int row, Board board)
            :base(column, row, board)
        {
            rowMax = board.rowMax;
            columnMax = board.columnMax;
            Texture = Texture2D.LoadStrict(textureResourcePath + "player.png");
            float x = column * Texture.Size.X + 200;
            int y = row * Texture.Size.Y + 100;
            Position = new Vector2F(x, (float)y);
        }
    }
}
