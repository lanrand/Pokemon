namespace Item.ItemInterface.BallBehavior
{
    public class NotBall: ICatchingBehavior
    {
        public int Catch()
        {
            return 0;
        }

        public void SetProbability(double p)
        {
            return;
        }

        public void SetPlayer(Player.Player player)
        {
            //throw new System.NotImplementedException();
        }

        public void SetTarget(Pokemon.Pokemon pokemon)
        {
            //throw new System.NotImplementedException();
        }
    }
}