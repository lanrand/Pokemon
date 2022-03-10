namespace Item.ItemInterface.HpBehavior
{
    public class HpRecover : IHpBehavior
    {
        private Pokemon.Pokemon _target;
        private int _recover;

        public HpRecover(int recover)
        {
            _recover = recover;
        }
        
        public void ChangeHp()
        {
            if (_target.HpCurrent1 + _recover <= _target.HpCurrent1)
            {
                _target.HpCurrent1 += _recover;
            }
            else
            {
                _target.HpCurrent1 = _target.HpDefault1;
            }
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