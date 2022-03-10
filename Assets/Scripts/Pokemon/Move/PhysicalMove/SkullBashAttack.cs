using Pokemon.Move.Category;
using Pokemon.State;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.PhysicalMove
{
    public class SkullBashAttack : Move //火箭头锤
    {
        public SkullBashAttack()
        {
            MoveName = "Skull Bash";

            Type = new Normal();

            Category = new Category.PhysicalMove();

            PpDefault = 15;

            PpCurrent = PpDefault;

            Power = 100;

            Accuracy = 100;
        }
    }
}