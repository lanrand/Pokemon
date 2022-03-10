using Pokemon.StatusCondition;

namespace Item.ItemInterface.StatusBehavior
{
    public class ClearStatus : IStatusBehavior
    {
        private Pokemon.Pokemon _target;
        public void StatusChange()
        {
            _target.StatusCondition1 = new Normal();
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