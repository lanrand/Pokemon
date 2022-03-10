using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.PhysicalMove
{
    public class WingAttack : Move //翅膀攻击
    {
        public WingAttack()
        {
            MoveName = "Wing Attack";

            Type = new Flying();

            Category = new Category.PhysicalMove();

            PpDefault = 35;
            
            PpCurrent = PpDefault;

            Power = 60;

            Accuracy = 100;
        }
    }
    
}