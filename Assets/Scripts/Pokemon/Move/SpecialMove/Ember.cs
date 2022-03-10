using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class Ember : Move //火花
    {
        public Ember()
        {
            MoveName = "Ember";

            Type = new Fire();

            Category = new Category.SpecialMove();

            PpDefault = 25;
            
            PpCurrent = PpDefault;

            Power = 40;

            Accuracy = 100;
        }

        public override int SetStatusCondition(Pokemon myPokemon, Pokemon yourPokemon)
        {
            if (Random.Range(0, 10) < 4)
            {
                yourPokemon.StatusCondition1 = new Burn();
                return 12;
            }
            return -1;
        }
    }
}