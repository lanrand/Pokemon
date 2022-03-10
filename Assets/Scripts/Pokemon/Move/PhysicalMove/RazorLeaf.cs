using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.PhysicalMove
{
    public class RazorLeaf : Move //飞叶快刀
    {
        public RazorLeaf()
        {
            MoveName = "Razor Leaf";

            Type = new Grass();

            Category = new Category.PhysicalMove();

            PpDefault = 25;
            
            PpCurrent = PpDefault;

            Power = 55;

            Accuracy = 95;

            C = 1;
        }
    }
}