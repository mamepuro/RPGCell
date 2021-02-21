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
        private const int cellNumMax = 36;
        /// <summary>
        /// board上のcellの集合
        /// </summary>
        public List<Cell> Cells { get; set; }
        /// <summary>
        /// 選択中のCell番号
        /// </summary>Mr
        public int CelectingCellNumber { get; set; }
        public Board()
        {
            Cells = new List<Cell>();
            for (int cellNum = 0; cellNum < cellNumMax; cellNum++)
            {
                var cell = new Cell(cellNum);
                Cells.Add(cell);
                Engine.AddNode(cell);
            }
            CelectingCellNumber = 1;
            Cells[CelectingCellNumber].Texture = Texture2D.LoadStrict(textureResourcesPath +"selectedcell.png");
            var player = new Player(0, this);
            Engine.AddNode(player);
        }

        private int CheckCellNumber(int cellNum)
        {
            cellNum = Math.Clamp(cellNum, 0, cellNumMax - 1);
            return cellNum;
        }

        private void SelectCell(int cellNum)
        {
            //if(Engine.Keyboard.GetKeyState(Key.D) == ButtonState.Hold || Engine.Keyboard.GetKeyState(Key.Right) == ButtonState.Hold)
            //{
            //    Cells[CelectingCellNumber].Texture = Texture2D.LoadStrict(textureResourcesPath + "/cell.png");
            //    CelectingCellNumber++;
            //    CelectingCellNumber = CheckCellNumber(CelectingCellNumber);
            //    Cells[CelectingCellNumber].Texture = Texture2D.LoadStrict(textureResourcesPath +"selectedcell.png");
            //}
            //if (Engine.Keyboard.GetKeyState(Key.A) == ButtonState.Hold || Engine.Keyboard.GetKeyState(Key.Left) == ButtonState.Hold)
            //{
            //    Cells[CelectingCellNumber].Texture = Texture2D.LoadStrict(textureResourcesPath+"cell.png");
            //    //Cells[CelectingCellNumber].Position += new Vector2F(300, 0);
            //    CelectingCellNumber--;
            //    CelectingCellNumber = CheckCellNumber(CelectingCellNumber);
            //    Cells[CelectingCellNumber].Texture = Texture2D.LoadStrict(textureResourcesPath +"selectedcell.png");
            //}
            //if (Engine.Keyboard.GetKeyState(Key.W) == ButtonState.Hold || Engine.Keyboard.GetKeyState(Key.Up) == ButtonState.Hold)
            //{
            //    Cells[CelectingCellNumber].Texture = Texture2D.LoadStrict(textureResourcesPath+"cell.png");
            //    CelectingCellNumber -= 6;
            //    CelectingCellNumber = CheckCellNumber(CelectingCellNumber);
            //    Cells[CelectingCellNumber].Texture = Texture2D.LoadStrict(textureResourcesPath+"selectedcell.png");
            //}
            //if (Engine.Keyboard.GetKeyState(Key.S) == ButtonState.Hold || Engine.Keyboard.GetKeyState(Key.Down) == ButtonState.Hold)
            //{
            //    Cells[CelectingCellNumber].Texture = Texture2D.LoadStrict(textureResourcesPath+"cell.png");
            //    //Cells[CelectingCellNumber].Position += new Vector2F(300, 0);
            //    CelectingCellNumber += 6;
            //    CelectingCellNumber = CheckCellNumber(CelectingCellNumber);
            //    Cells[CelectingCellNumber].Texture = Texture2D.LoadStrict(textureResourcesPath+"selectedcell.png");
            //}
        }

        protected override void OnUpdate()
        {
            //SelectCell(CelectingCellNumber);
            base.OnUpdate();
        }
    }
}
