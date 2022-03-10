using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.StatusMove
{
    public class Growth : Move //生长
    {
        public Growth()
        {
            MoveName = "Growth";

            Type = new Normal();

            Category = new Category.StatusMove();

            PpDefault = 20;
            
            PpCurrent = PpDefault;

            Accuracy = 900;
        }
        
        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon) 
        {
            battlePVE.battleInformation += myPokemon.SpeciesName1 + " increases the SpecialAttack!\n";
            battlePVP.battleInformation += myPokemon.SpeciesName1 + " increases the SpecialAttack!\n";
            myPokemon.SpecialAttackLv1 += 1;
            int[] tmp = {2, 1};
            return tmp;
        }
    }
}