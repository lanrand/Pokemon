using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class Thunder : Move //打雷
    {
        public Thunder()
        {
            MoveName = "Thunder";

            Type = new Electric();

            Category = new Category.SpecialMove();

            PpDefault = 10;
            
            PpCurrent = PpDefault;

            Power = 120;

            Accuracy = 70;
        }
        
        public override int SetStatusCondition(Pokemon myPokemon, Pokemon yourPokemon)
        {
            if (Random.Range(0, 10) < 3)
            {
                yourPokemon.StatusCondition1 = new Paralysis();
                return 10;
            }
            return -1;
        }

    }
}