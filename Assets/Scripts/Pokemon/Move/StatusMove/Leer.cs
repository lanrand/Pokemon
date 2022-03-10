using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.StatusMove
{
    public class Leer : Move //瞪眼
    {
        public Leer()
        {
            MoveName = "Leer";

            Type = new Normal();

            Category = new Category.StatusMove();

            PpDefault = 30;
            
            PpCurrent = PpDefault;

            Accuracy = 100;
        }
        
        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon) 
        {
            battlePVE.battleInformation += yourPokemon.SpeciesName1 + " reduces the Defense!\n";
            battlePVP.battleInformation += yourPokemon.SpeciesName1 + " reduces the Defense!\n";
            yourPokemon.LastReceived1 = this;
            yourPokemon.DefenseLv1 -= 1;
            int[] tmp = {11, -1};
            return tmp;
        }
    }
}