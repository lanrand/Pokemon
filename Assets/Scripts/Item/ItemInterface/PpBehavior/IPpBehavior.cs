namespace Item.ItemInterface.PpBehavior
{
    public interface IPpBehavior
    {
        public void PpChange();
        
        public void SetTarget(Pokemon.Pokemon target);

        public Pokemon.Pokemon GetTarget();
    }
}