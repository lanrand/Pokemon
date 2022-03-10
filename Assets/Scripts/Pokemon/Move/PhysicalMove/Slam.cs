using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.PhysicalMove
{
    public class Slam : Move //摔打
    {
        public Slam()
        {
            MoveName = "Slam";

            Type = new Normal();

            Category = new Category.PhysicalMove();
            
            PpDefault = 20;
            
            PpCurrent = PpDefault;

            Power = 80;

            Accuracy = 75;
        }
    }
}