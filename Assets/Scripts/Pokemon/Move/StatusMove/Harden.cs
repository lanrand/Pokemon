using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.StatusMove
{
    public class Harden : Move //变硬
    {
        public Harden()
        {
            MoveName = "Harden";

            Type = new Normal();

            Category = new Category.StatusMove();

            PpDefault = 30;
            
            PpCurrent = PpDefault;

            Accuracy = 900;
        }
        
        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon) 
        {
            battlePVE.battleInformation += myPokemon.SpeciesName1 + " increases the Defense!\n";
            battlePVP.battleInformation += myPokemon.SpeciesName1 + " increases the Defense!\n";
            myPokemon.DefenseLv1 += 1;
            int[] tmp = {1, 1};
            return tmp;
        }
    }
}