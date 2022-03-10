using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Pokemon.State
{
    public class Rage : State//愤怒
    {
        public Rage()
        {
            StateName = "Rage";
            Round = 2;
            //受到攻击则攻击+1级
        }

        public override int AfterAction(Pokemon myPokemon, Pokemon yourPokemon)
        {
            Round--;
            if (Round <= 0)
            {
                int i = myPokemon.CurrentStates1.IndexOf(this);
                myPokemon.CurrentStates1.Remove(this);
                myPokemon.CurrentStates1.Insert(i, new NoState());
            }
            return myPokemon.HpCurrent1;
        }
    }
}