using Item.ItemInterface.BallBehavior;
using Item.ItemInterface.BuyBehavior;
using Item.ItemInterface.HpBehavior;
using Item.ItemInterface.PpBehavior;
using Item.ItemInterface.StatusBehavior;

namespace Item.Ball
{
    public class MasterBall : Ball
    {
        public MasterBall()
        {
            this.Name = "MasterBall"; //大师球
            this.Id = 8;
            this.SpritePath = "Sprite Assets/Stuff/masterBall";
            this.HpBehavior = new HpRecover(0);
            this.PpBehavior = new PpRecover(0);
            this.StatusBehavior = new NoStatusChange();
            BuyingBehavior = new CanBuy(this);
            this.Cost = 2000;//别卖
            this.CatchingBehavior1 = new CatchImplement();
            this.CatchingBehavior.SetProbability(255);
        }
    }
}
// this.Name = "GreatBall"; //超级球
// this.Id = 7;
// this.SpritePath = "Sprite Assets/Stuff/greatBall";
// this.HpBehavior = new HpRecover(0);
// this.PpBehavior = new PpRecover(0);
// this.StatusBehavior = new NoStatusChange();
// BuyingBehavior = new CanBuy(this);
// this.Cost = 60;
// this.CatchingBehavior.SetProbability(1.5);