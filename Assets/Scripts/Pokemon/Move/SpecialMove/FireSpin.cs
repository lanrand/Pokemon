using Pokemon.Move.Category;
using Pokemon.State;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class FireSpin : Move //火焰漩涡
    {
        public FireSpin()
        {
            MoveName = "Fire Spin";

            Type = new Fire();

            Category = new Category.SpecialMove();

            PpDefault = 15;
            
            PpCurrent = PpDefault;

            Power = 15;

            Accuracy = 70;
        }

        public override int SetState(Pokemon myPokemon, Pokemon yourPokemon)
        {
            yourPokemon.CurrentStates1.Add(new Bound());
            return 15;
        }
    }
}