namespace Item.ItemInterface.StatusBehavior
{
    public class NoStatusChange : IStatusBehavior
    {        
        private Pokemon.Pokemon _target;
        public void StatusChange()
        {
            
        }

        public void SetTarget(Pokemon.Pokemon target)
        {
            this._target = target;
        }

        public Pokemon.Pokemon GetTarget()
        {
            return _target;
        }
    }
}