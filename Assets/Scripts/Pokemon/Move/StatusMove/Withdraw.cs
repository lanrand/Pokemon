using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.StatusMove
{
    public class Withdraw : Move //缩入壳中
    {
        public Withdraw()
        {
            MoveName = "Withdraw";

            Type = new Water();

            Category = new Category.StatusMove();

            PpDefault = 40;

            PpCurrent = PpDefault;

            Accuracy = 900;
        }
        
        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon)
        {
            battlePVE.battleInformation += myPokemon.SpeciesName1 + " increase the Defense!\n";
            battlePVP.battleInformation += myPokemon.SpeciesName1 + " increase the Defense!\n";
            myPokemon.DefenseLv1 += 1;
            int[] tmp = {1, 1};
            return tmp;
        }
    }
}