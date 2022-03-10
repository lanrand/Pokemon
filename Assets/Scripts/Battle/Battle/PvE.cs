using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;
using UnityEngine;

namespace Battle
{
    public class PvE : Battle
    {
        public PvE(InFight me)
        {
            Me = new InFight();
            Me = me;
            You = new InFight();
            You = new InFight(me);
        }
        public PvE(InFight me,int a)
        {
            Me = new InFight();
            Me = me;
            You = new InFight();
            You = new InFight(a);
        }
    }
}