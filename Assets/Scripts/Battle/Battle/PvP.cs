using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Battle
{
    public class PvP: Battle
    {
        public PvP(InFight me, InFight you)
        {
            Me = me;
            You = you;
        }
    }
}