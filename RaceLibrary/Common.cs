using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CombatLibrary;

namespace RaceLibrary
{
    public abstract class Race
    {
        public virtual List<CombatEffect> GetCombatEffects();
    }

    public class NoRace : Race
    {
    }

    public abstract Technologies
}
