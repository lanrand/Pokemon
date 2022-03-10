using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move.StatusMove
{
    public class Agility : Move //高速移动
    {
        public Agility()
        {
            MoveName = "Agility";

            Type = new Psychic();

            Category = new Category.StatusMove();

            PpDefault = 30;
            
            PpCurrent = PpDefault;

            Accuracy = 900;
        }
        
        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon) 
        {
            battlePVE.battleInformation += myPokemon.SpeciesName1 + " increases the Speed!\n";
            battlePVP.battleInformation += myPokemon.SpeciesName1 + " increases the Speed!\n";
            myPokemon.SpeedLv1 += 2;
            int[] tmp = {4, 2};
            return tmp;
        }
    }
}