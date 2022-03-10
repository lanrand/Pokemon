using Item.ItemInterface.BallBehavior;
using Item.ItemInterface.BuyBehavior;
using Item.ItemInterface.HpBehavior;
using Item.ItemInterface.PpBehavior;
using Item.ItemInterface.StatusBehavior;

namespace Item.Ball
{
    public class PokeBall : Ball
    {
        public PokeBall()
        {
            this.Name = "PokeBall"; //精灵球
            this.Id = 6;
            this.CatchingBehavior1 = new CatchImplement();
            this.CatchingBehavior.SetProbability(1.0);
            this.SpritePath = "Sprite Assets/Stuff/pokeBall";
            this.HpBehavior = new HpRecover(0);
            this.PpBehavior = new PpRecover(0);
            this.StatusBehavior = new NoStatusChange();
            BuyingBehavior = new CanBuy(this);
            Cost = 20;

        }
    }
}