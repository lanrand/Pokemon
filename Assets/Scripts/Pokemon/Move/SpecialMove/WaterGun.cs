using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class WaterGun : Move //水枪
    {
        public WaterGun()
        {
            MoveName = "Water Gun";

            Type = new Water();

            Category = new Category.SpecialMove();

            PpDefault = 25;
            
            PpCurrent = PpDefault;

            Power = 40;

            Accuracy = 100;
        }
    }
}