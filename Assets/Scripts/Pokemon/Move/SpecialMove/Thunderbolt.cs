using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class Thunderbolt : Move //十万伏特
    {
        public Thunderbolt()
        {
            MoveName = "Thunderbolt";

            Type = new Electric();

            Category = new Category.SpecialMove();

            PpDefault = 15;
            
            PpCurrent = PpDefault;

            Power = 95;

            Accuracy = 100;
        }

        public override int SetStatusCondition(Pokemon myPokemon, Pokemon yourPokemon)
        {
            if (Random.Range(0, 10) < 1)
            {
                yourPokemon.StatusCondition1 = new Paralysis();
                return 10;
            }
            return -1;
        }
    }
}