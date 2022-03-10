using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.PhysicalMove
{
    public class QuickAttack : Move //电光一闪
    {
        public QuickAttack()
        {
            MoveName = "Quick Attack";

            Type = new Normal();

            Category = new Category.PhysicalMove();

            PpDefault = 30;
            
            PpCurrent = PpDefault;

            Power = 40;

            Accuracy = 100;

            Priority = 1;
        }
    }
    
}