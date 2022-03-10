using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class ThunderShock : Move //电击
    {
        public ThunderShock()
        {
            MoveName = "Thunder Shock";

            Type = new Electric();

            Category = new Category.SpecialMove();

            PpDefault = 30;
            
            PpCurrent = PpDefault;

            Power = 40;

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