using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Pokemon.State
{
    public class Disable : State//定身法
    {
        protected Move.Move LastUse;

        public Move.Move LastUse1
        {
            get => LastUse;
            set => LastUse = value;
        }

        public Disable(Move.Move lastUse)
        {
            StateName = "Disable";
            Round = Random.Range(2, 6);
            LastUse = lastUse;
            //不能使用在进入定身法状态前最后使用的招式,2~5回合。
        }

        public override int AfterAction(Pokemon myPokemon, Pokemon yourPokemon)
        {
            LastUse.Available1 = false;
            Round--;
            if (Round <= 0)
            {
                LastUse.Available1 = true;
                int i = myPokemon.CurrentStates1.IndexOf(this);
                myPokemon.CurrentStates1.Remove(this);
                myPokemon.CurrentStates1.Insert(i, new NoState());
            }
            return myPokemon.HpCurrent1;
        }
    }
}