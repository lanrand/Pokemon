using Item.ItemInterface.BuyBehavior;
using Item.ItemInterface.HpBehavior;
using Item.ItemInterface.PpBehavior;
using Item.ItemInterface.StatusBehavior;

namespace Item.Medicine
{
    public class SuperPotion : Medicine//30hp
    {
        public SuperPotion()
        {
            this.Name = "Super Potion";
            this.Id = 2;
            this.SpritePath = "Sprite Assets/Stuff/superpotion";
            this.HpBehavior = new HpRecover(60);
            this.PpBehavior = new PpRecover(0);
            this.StatusBehavior = new NoStatusChange();
            BuyingBehavior = new CanBuy(this);
            Cost = 70;
        }
        
    }
}