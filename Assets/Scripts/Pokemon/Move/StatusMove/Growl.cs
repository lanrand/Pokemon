using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.StatusMove
{
    public class Growl : Move //叫声
    {
        public Growl()
        {
            MoveName = "Growl";

            Type = new Normal();

            Category = new Category.StatusMove();

            PpDefault = 40;
            
            PpCurrent = PpDefault;

            Accuracy = 100;
        }
        
        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon) 
        {
            battlePVE.battleInformation += yourPokemon.SpeciesName1 + " reduces the Attack!\n";
            battlePVP.battleInformation += yourPokemon.SpeciesName1 + " reduces the Attack!\n";
            yourPokemon.LastReceived1 = this;
            yourPokemon.AttackLv1 -= 1;
            int[] tmp = {10, -1};
            return tmp;
        }
    }
}