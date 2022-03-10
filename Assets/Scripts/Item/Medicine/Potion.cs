using Item.ItemInterface.BuyBehavior;
using Item.ItemInterface.HpBehavior;
using Item.ItemInterface.PpBehavior;
using Item.ItemInterface.StatusBehavior;

namespace Item.Medicine
{
    public class Potion : Medicine //伤药
    {
        public Potion()
        {
            this.Name = "Potion";
            this.Id = 1;
            this.SpritePath = "Sprite Assets/Stuff/potion";
            this.HpBehavior = new HpRecover(20);
            this.PpBehavior = new PpRecover(0);
            this.StatusBehavior = new NoStatusChange();
            BuyingBehavior = new CanBuy(this);
            Cost = 30;
        }
        
    }
}