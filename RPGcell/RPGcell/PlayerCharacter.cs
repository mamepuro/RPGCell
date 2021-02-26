using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    class PlayerCharacter:Character
    {
        public PlayerCharacter(int column, int row, Board board)
            :base(column, row, board)
        {
            Texture = Texture2D.LoadStrict(textureResourcePath + "player.png");
            float x = (CellNumber % 6) * Texture.Size.X + 200;
            int y = (CellNumber / 6) * Texture.Size.Y + 100;
            Position = new Vector2F(x, (float)y);
        }
    }
}
