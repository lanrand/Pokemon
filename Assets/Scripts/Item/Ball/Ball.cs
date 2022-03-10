using Item.ItemInterface.BallBehavior;
using Item.ItemInterface.BuyBehavior;
using Item.ItemInterface.HpBehavior;
using Item.ItemInterface.PpBehavior;
using Item.ItemInterface.StatusBehavior;

namespace Item.Ball
{
    public abstract class Ball : Item

    {
        //protected int Cost;
        
        protected Pokemon.Pokemon Targer;

        public Pokemon.Pokemon Targer1
        {
            get => Targer;
            set { Targer = value;this.CatchingBehavior.SetTarget(value); }
        }

        protected Player.Player Player;//zhan dou zhong de player

        public Player.Player Player1
        {
            get => Player;
            set { Player = value; this.CatchingBehavior.SetPlayer(value);}
        }

        // public Ball()
        // {
        //     //this.BuyingBehavior = new CanBuy(this);
        //     // this.HpBehavior = new HpRecover(0);
        //     // this.PpBehavior = new PpRecover(0);
        //     // this.StatusBehavior = new NoStatusChange();
        //     // this.CatchingBehavior = new CatchImplement();
        // }
    }
}