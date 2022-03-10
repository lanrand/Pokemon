using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.PhysicalMove
{
    public class VineWhip : Move //藤鞭
    {
        public VineWhip()
        {
            MoveName = "Vine Whip";

            Type = new Grass();

            Category = new Category.PhysicalMove();

            PpDefault = 10;
            
            PpCurrent = PpDefault;

            Power = 35;

            Accuracy = 100;
        }
    }
}