namespace Item.Medicine
{
    public abstract class Medicine :Item
    {
        
        protected Player.Player Player;
        
        protected Pokemon.Pokemon Target;


        

        public Player.Player Player1
        {
            get => Player;
            set => Player = value;
        }

        public void SetTarget(Pokemon.Pokemon target)
        {
            this.Target = target;
            this.HpBehavior.SetTarget(target);
            this.PpBehavior.SetTarget(target);
            this.StatusBehavior.SetTarget(target);
        }

    }
}