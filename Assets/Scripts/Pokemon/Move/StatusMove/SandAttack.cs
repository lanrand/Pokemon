using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.StatusMove
{
    public class SandAttack : Move //泼沙
    {
        public SandAttack()
        {
            MoveName = "Sand Attack";

            Type = new Normal();

            Category = new Category.StatusMove();

            PpDefault = 15;
            
            PpCurrent = PpDefault;

            Accuracy = 100;
        }
        
        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon) 
        {
            battlePVE.battleInformation += yourPokemon.SpeciesName1 + " reduce the Accuracy!\n";
            battlePVP.battleInformation += yourPokemon.SpeciesName1 + " reduce the Accuracy!\n";
            yourPokemon.LastReceived1 = this;
            yourPokemon.AccuracyLv1 -= 1;
            int[] tmp = {15, -1};
            return tmp;
        }
    }
}