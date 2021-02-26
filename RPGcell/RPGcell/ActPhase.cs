using System;
using System.Collections.Generic;
using System.Text;
using Altseed2;

namespace RPGcell
{
    public enum ActPhase
    {
        /// <summary>
        /// Cellを選択するフェーズ。Playerは自由にCellを選択できる
        /// </summary>
        SelectingCellPhase,
        /// <summary>
        /// キャラクターの移動するCellを決定するフェーズ
        /// </summary>
        DecideCharacterMovePhase,
    }
}
