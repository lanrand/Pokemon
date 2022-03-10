using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.PhysicalMove
{
    public class Slash : Move //劈开
    {
        public Slash()
        {
            MoveName = "Slash";

            Type = new Normal();

            Category = new Category.PhysicalMove();

            PpDefault = 20;
            
            PpCurrent = PpDefault;

            Power = 70;

            Accuracy = 100;

            C = 1;
        }
    }
}