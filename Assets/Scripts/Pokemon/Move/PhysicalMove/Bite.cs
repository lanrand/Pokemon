using Pokemon.Move.Category;
using Pokemon.State;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.PhysicalMove
{
    public class Bite : Move //咬住
    {
        public Bite()
        {
            MoveName = "Bite";

            Type = new Normal();

            Category = new Category.PhysicalMove();

            PpDefault = 25;
            
            PpCurrent = PpDefault;

            Power = 60;

            Accuracy = 100;
        }
        
        public override int SetState(Pokemon myPokemon, Pokemon yourPokemon)
        {
            if (Random.Range(0, 10) < 3)
            {
                yourPokemon.CurrentStates1.Add(new Flinch());
                return 12;
            }
            return -1;
        }
    }
}