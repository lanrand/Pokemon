using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.StatusMove
{
    public class Screech : Move //刺耳声
    {
        public Screech()
        {
            MoveName = "Screech";

            Type = new Normal();

            Category = new Category.StatusMove();

            PpDefault = 40;
            
            PpCurrent = PpDefault;

            Accuracy = 85;
        }
        
        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon) 
        {
            battlePVE.battleInformation += yourPokemon.SpeciesName1 + " reduce the Defense!\n";
            battlePVP.battleInformation += yourPokemon.SpeciesName1 + " reduce the Defense!\n";
            yourPokemon.LastReceived1 = this;
            yourPokemon.DefenseLv1 -= 2;
            int[] tmp = {11, -2};
            return tmp;
        }
    }
}