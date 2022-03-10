using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.StatusMove
{
    public class Minimize : Move //变小
    {
        public Minimize()
        {
            MoveName = "Minimize";

            Type = new Normal();

            Category = new Category.StatusMove();

            PpDefault = 20;
            
            PpCurrent = PpDefault;

            Accuracy = 900;
        }
        
        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon) 
        {
            battlePVE.battleInformation += myPokemon.SpeciesName1 + " increases the chances of Dodging!\n";
            battlePVP.battleInformation += myPokemon.SpeciesName1 + " increases the chances of Dodging!\n";
            myPokemon.EvasionLv1 += 1;
            int[] tmp = {6, 1};
            return tmp;
        }
    }
}