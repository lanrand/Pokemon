using Item.ItemInterface.BuyBehavior;
using Item.ItemInterface.HpBehavior;
using Item.ItemInterface.PpBehavior;
using Item.ItemInterface.StatusBehavior;

namespace Item.Medicine
{
    public class FullHeal : Medicine //万灵药
    {
        public FullHeal()
        {
            this.Name = "Full Heal";
            this.Id = 5;
            this.SpritePath = "Sprite Assets/Stuff/FullHeal";
            this.HpBehavior = new HpRecover(0);
            this.PpBehavior = new PpRecover(0);
            this.StatusBehavior = new ClearStatus();
            BuyingBehavior = new CanBuy(this);
            Cost = 60;
        }
    }
}