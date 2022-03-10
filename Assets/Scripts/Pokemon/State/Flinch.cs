using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Pokemon.State
{
    public class Flinch : State//畏缩
    {
        public Flinch()
        {
            StateName = "Flinch";
            //后手该回合无法出招
        }

        public override int AfterAction(Pokemon myPokemon, Pokemon yourPokemon)
        {
            int i = myPokemon.CurrentStates1.IndexOf(this);
            myPokemon.CurrentStates1.Remove(this);
            myPokemon.CurrentStates1.Insert(i, new NoState());
            return myPokemon.HpCurrent1;
        }
    }
}