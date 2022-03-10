using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.PhysicalMove
{
    public class Scratch : Move //抓
    {
        public Scratch()
        {
            MoveName = "Scratch";

            Type = new Normal();

            Category = new Category.PhysicalMove();

            PpDefault = 35;
            
            PpCurrent = PpDefault;

            Power = 40;

            Accuracy = 100;
        }
    }
}