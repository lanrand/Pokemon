using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.PhysicalMove
{
    public class Pound : Move //拍击
    {
        public Pound()
        {
            MoveName = "Pound";

            Type = new Normal();

            Category = new Category.PhysicalMove();

            PpDefault = 35;
            
            PpCurrent = PpDefault;

            Power = 40;

            Accuracy = 100;
        }
    }
    
}