using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.StatusMove
{
    public class TailWhip : Move //摇尾巴
    {
        public TailWhip()
        {
            MoveName = "Tail Whip";

            Type = new Normal();

            Category = new Category.StatusMove();

            PpDefault = 30;

            PpCurrent = PpDefault;
            
            Accuracy = 100;
        }
        
        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon) 
        {
            battlePVE.battleInformation += yourPokemon.SpeciesName1 + " reduce the Defense!\n";
            battlePVP.battleInformation += yourPokemon.SpeciesName1 + " reduce the Defense!\n";
            yourPokemon.LastReceived1 = this;
            yourPokemon.DefenseLv1 -= 1;
            int[] tmp = {11, -1};
            return tmp;
        }
    }
}