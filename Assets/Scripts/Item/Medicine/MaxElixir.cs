using Item.ItemInterface.BuyBehavior;
using Item.ItemInterface.HpBehavior;
using Item.ItemInterface.PpBehavior;
using Item.ItemInterface.StatusBehavior;

namespace Item.Medicine
{
    public class MaxElixir : Medicine //pp多项全补剂
    {
        public MaxElixir()
        {
            this.Name = "Max Elixir";
            this.Id = 4;
            this.SpritePath = "Sprite Assets/Stuff/max_elixir";
            this.HpBehavior = new HpRecover(0);
            this.PpBehavior = new PpRecover(50);
            this.StatusBehavior = new NoStatusChange();
            BuyingBehavior = new CanBuy(this);
            Cost = 150;
        }
    }
}