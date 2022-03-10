using Pokemon.Move.Category;
using Pokemon.State;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.PhysicalMove
{
    public class Rage : Move //愤怒
    {
        public Rage()
        {
            MoveName = "Rage";

            Type = new Normal();

            Category = new Category.PhysicalMove();

            PpDefault = 20;
            
            PpCurrent = PpDefault;

            Power = 20;

            Accuracy = 100;
        }

        public override int SetState(Pokemon myPokemon, Pokemon yourPokemon)
        {
            myPokemon.CurrentStates1.Add(new State.Rage());
            return 3;
        }
    }
}