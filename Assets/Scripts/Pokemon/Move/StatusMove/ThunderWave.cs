using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.StatusMove
{
    public class ThunderWave : Move //电磁波
    {
        public ThunderWave()
        {
            MoveName = "Thunder Wave";

            Type = new Electric();

            Category = new Category.StatusMove();

            PpDefault = 20;

            PpCurrent = PpDefault;
            
            Accuracy = 100;
        }
        
        public override int SetStatusCondition(Pokemon myPokemon, Pokemon yourPokemon)
        {
            battlePVE.battleInformation += yourPokemon.SpeciesName1 + " is Paralysis!\n";
            battlePVP.battleInformation += yourPokemon.SpeciesName1 + " is Paralysis!\n";
            yourPokemon.LastReceived1 = this;
            yourPokemon.StatusCondition1 = new Paralysis();
            return 10;
        }
    }
}