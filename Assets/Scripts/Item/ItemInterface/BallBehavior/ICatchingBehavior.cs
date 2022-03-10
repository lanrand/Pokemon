namespace Item.ItemInterface.BallBehavior
{
    public interface ICatchingBehavior
    {
        public int Catch();

        public void SetProbability(double p);

        public void SetPlayer(Player.Player player);

        public void SetTarget(Pokemon.Pokemon pokemon);
    }
}