using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.StatusMove
{
    public class AcidArmor : Move //溶化
    {
        public AcidArmor()
        {
            MoveName = "Acid Armor";

            Type = new Poison();

            Category = new Category.StatusMove();

            PpDefault = 40;
            
            PpCurrent = PpDefault;

            Accuracy = 900;
        }
        
        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon) 
        {
            battlePVE.battleInformation += myPokemon.SpeciesName1 + " increases the Defense!\n";
            battlePVP.battleInformation += myPokemon.SpeciesName1 + " increases the Defense!\n";
            myPokemon.DefenseLv1 += 2;
            int[] tmp = {1, 2};
            return tmp;
        }
    }
}