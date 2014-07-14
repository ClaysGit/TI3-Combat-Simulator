using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary
{
    public class CombatEffect
    {

    }

    public enum CombatEffectResolutionStep
    {
        PreCombat,
        PostCombat
    }

    public class RoundResults
    {
        public int Player1Hits { get; set; }
        public int Player2Hits { get; set; }
    }
}
