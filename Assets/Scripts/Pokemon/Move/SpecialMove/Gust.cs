using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class Gust : Move //起风
    {
        public Gust()
        {
            MoveName = "Gust";

            Type = new Flying();

            Category = new Category.SpecialMove();

            PpDefault = 35;
            
            PpCurrent = PpDefault;

            Power = 40;

            Accuracy = 100;
        }
    }
}