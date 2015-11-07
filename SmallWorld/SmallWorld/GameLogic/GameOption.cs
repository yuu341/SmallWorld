using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.GameLogic
{
    class GameOption
    {
        /// <summary>
        /// プレイ人数
        /// </summary>
        public int PlayerCount { get; set; }

        /// <summary>
        /// チームプレイかどうか
        /// </summary>
        public bool IsTeamPlay { get; set; }

        /// <summary>
        /// フィールド
        /// </summary>
        public object PlayingField { get; set; }
    }
}
