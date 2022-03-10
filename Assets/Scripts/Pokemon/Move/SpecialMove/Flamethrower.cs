using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class Flamethrower : Move //喷射火焰
    {
        public Flamethrower()
        {
            MoveName = "Flamethrower";

            Type = new Fire();

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
                yourPokemon.StatusCondition1 = new Burn();
                return 12;
            }
            return -1;
        }
    }
}