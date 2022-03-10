using Item.ItemInterface.BuyBehavior;
using Item.ItemInterface.HpBehavior;
using Item.ItemInterface.PpBehavior;
using Item.ItemInterface.StatusBehavior;

//using UnityEngine.UI;

namespace Item.Medicine
{
    public class Elixir: Medicine //pp多项小补剂
    {

        public Elixir()
        {
            this.Name = "Elixir";
            this.Id = 3;
            this.SpritePath = "Sprite Assets/Stuff/elixir";
            this.HpBehavior = new HpRecover(0);
            this.PpBehavior = new PpRecover(10);
            this.StatusBehavior = new NoStatusChange();
            BuyingBehavior = new CanBuy(this);
            Cost = 60;
        }
    }
}