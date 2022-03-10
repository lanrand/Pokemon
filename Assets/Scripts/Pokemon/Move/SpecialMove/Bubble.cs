using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class Bubble : Move //泡沫
    {
        public Bubble()
        {
            MoveName = "Bubble";

            Type = new Water();

            Category = new Category.SpecialMove();

            PpDefault = 30;
            
            PpCurrent = PpDefault;

            Power = 20;

            Accuracy = 100;
        }


        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon)
        {
            int[] tmp = {-1, 0};
            if (Random.Range(0, 10) < 1)
            {
                yourPokemon.SpeedLv1 -= 1;
                tmp[0] = 14;
                tmp[1] = -1;
            }
            return tmp;
        }
        
    }
}