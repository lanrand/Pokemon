using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class HydroPump : Move //水炮
    {
        public HydroPump()
        {
            MoveName = "Hydro Pump";

            Type = new Water();

            Category = new Category.SpecialMove();

            PpDefault = 5;
            
            PpCurrent = PpDefault;

            Power = 120;

            Accuracy = 80;
        }
    }
}