using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    class ActWindow:SpriteNode
    {
        private const string textureRsourcesPath = "Resources/Textures/";
        private const string fontResourcePath = "Resources/Font/";
        /// <summary>
        /// Windowに表示する文字
        /// </summary>
        private string ActionName { get; set; }
        private TextNode text { get; set; }
        public ActWindow(string actionName, Vector2F position)
        {
            ActionName = actionName;
            Position = position;
            Texture = Texture2D.LoadStrict(textureRsourcesPath + "actwindow.png");
            text = new TextNode();
            text.Font = Font.LoadDynamicFontStrict(fontResourcePath + "AiharaHudemojiKaisho3.00.ttf", 30);
            text.Position = this.Position + new Vector2F(3, 0);
            text.Text = ActionName;
        }
    }
}
