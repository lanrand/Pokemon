using Pokemon.Move.Category;
using Pokemon.State;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class SolarBeamAttack : Move //日光束
    {
        public SolarBeamAttack()
        {
            MoveName = "Solar Beam";

            Type = new Grass();

            Category = new Category.SpecialMove();

            PpDefault = 15;

            PpCurrent = PpDefault;

            Power = 100;

            Accuracy = 100;
        }
    }
}