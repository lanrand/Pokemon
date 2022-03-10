using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.PhysicalMove
{
    public class Tackle : Move //撞击
    {
        public Tackle()
        {
            MoveName = "Tackle";

            Type = new Normal();

            Category = new Category.PhysicalMove();

            PpDefault = 35;
            
            PpCurrent = PpDefault;

            Power = 35;

            Accuracy = 95;
        }
    }
}