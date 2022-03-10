using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class Sludge : Move //污泥攻击
    {
        public Sludge()
        {
            MoveName = "Sludge";

            Type = new Type.Poison();

            Category = new Category.SpecialMove();

            PpDefault = 30;
            
            PpCurrent = PpDefault;

            Power = 40;

            Accuracy = 100;
        }

        public override int SetStatusCondition(Pokemon myPokemon, Pokemon yourPokemon)
        {
            if (Random.Range(0, 10) <3)
            {
                yourPokemon.StatusCondition1 = new StatusCondition.Poison();
                return 11;
            }
            return -1;
        }
    }
}