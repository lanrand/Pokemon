using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Pokemon.State
{
    public class Stockpile : State//蓄力
    {
        protected Move.Move Foco;

        public Move.Move Foco1
        {
            get => Foco;
            set => Foco = value;
        }

        public Stockpile(Move.Move foco)
        {
            StateName = "State";
            Round = 2;
            Foco = foco;
        }

        public override int AfterAction(Pokemon myPokemon, Pokemon yourPokemon)
        {
            Round--;
            if (Round == 0)
            {
                int j = myPokemon.CurrentStates1.IndexOf(this);
                myPokemon.CurrentStates1.Remove(this);
                myPokemon.CurrentStates1.Insert(j, new NoState());
                for (int i = 0; i < myPokemon.CurrentMoves1.Length; i++)
                    myPokemon.CurrentMoves1[i].Available1 = true;
            }

            return myPokemon.HpCurrent1;
        }
    }
}