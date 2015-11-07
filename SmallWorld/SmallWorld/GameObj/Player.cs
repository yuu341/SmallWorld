using SmallWorld.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.GameObj
{
    class Player
    {
        /// <summary>
        /// プレイヤー名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// オートプレイをするかどうか
        /// </summary>
        public bool AutoPlay { get; set; }

        /// <summary>
        /// オートプレイをする場合のＡＩ
        /// </summary>
        public AutoPlayer AutoPlayer { get; set; }

    }
}
