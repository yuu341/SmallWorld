using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.GameObj.Character
{
    /// <summary>
    /// 特に能力はない、数が多い
    /// </summary>
    class Ratman : ICharacter
    {
        public int MaxTokenNumber { get { return 14; } }
        public int TokenNumber { get { return 8; } }
        public string Package { get { return "normal"; } }
    }
}
