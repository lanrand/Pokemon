namespace Item.ItemInterface.PpBehavior
{
    public class PpRecover : IPpBehavior
    {
        private Pokemon.Pokemon _target;
        private int _recover;

        public PpRecover(int recover)
        {
            this._recover = recover;
        }
        
        public void PpChange()
        {
            for (int i = 0; i < 4; i++)
            {
                if (_target.CurrentMoves1[i].PpCurrent1 + _recover <= _target.CurrentMoves1[i].PpDefault1)
                {
                    _target.CurrentMoves1[i].PpCurrent1 += _recover;
                }
                else
                {
                    _target.CurrentMoves1[i].PpCurrent1 = _target.CurrentMoves1[i].PpDefault1;
                }
            }
        }


        public void SetTarget(Pokemon.Pokemon target)
        {
            _target = target;
        }

        public Pokemon.Pokemon GetTarget()
        {
            return _target;
        }
    }
}