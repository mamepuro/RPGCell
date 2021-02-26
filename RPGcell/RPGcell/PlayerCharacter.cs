using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    class PlayerCharacter:Character
    {
        public PlayerCharacter(Vector2F position)
        {
            Texture = Texture2D.LoadStrict(textureResourcePath + "player.png");
            Position = position;
        }
    }
}
