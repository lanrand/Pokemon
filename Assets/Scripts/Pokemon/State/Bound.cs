using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Pokemon.State
{
    public class Bound : State//束缚
    {
        public Bound()
        {
            StateName = "Bound";
            Round = Random.Range(2, 6);
            //2~5回合，-1/16HP，无法替换/逃走
        }

        public override int AfterAction(Pokemon myPokemon, Pokemon yourPokemon)
        {
            myPokemon.HpCurrent1 -= myPokemon.HpDefault1/16;
            if (myPokemon.HpCurrent1 <= 0)
                myPokemon.HpCurrent1 = 0;
            Round--;
            if (Round == 0)
            {
                int i = myPokemon.CurrentStates1.IndexOf(this);
                myPokemon.CurrentStates1.Remove(this);
                myPokemon.CurrentStates1.Insert(i, new NoState());
            }
            return myPokemon.HpCurrent1;
        }
    }
}