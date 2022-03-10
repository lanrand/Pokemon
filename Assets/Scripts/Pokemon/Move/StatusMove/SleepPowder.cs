using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.StatusMove
{
    public class SleepPowder : Move //催眠粉
    {
        public SleepPowder()
        {
            MoveName = "Sleep Powder";

            Type = new Grass();

            Category = new Category.StatusMove();

            PpDefault = 15;
            
            PpCurrent = PpDefault;

            Accuracy = 75;
        }
        
        public override int SetStatusCondition(Pokemon myPokemon, Pokemon yourPokemon)
        {
            battlePVE.battleInformation += yourPokemon.SpeciesName1 + " is Sleep!\n";
            battlePVP.battleInformation += yourPokemon.SpeciesName1 + " is Sleep!\n";
            yourPokemon.LastReceived1 = this;
            yourPokemon.StatusCondition1 = new Sleep();
            return 13;
        }
    }
}