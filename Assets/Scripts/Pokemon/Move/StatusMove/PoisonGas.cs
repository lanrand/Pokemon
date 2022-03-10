using Pokemon.Move.Category;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.StatusMove
{
    public class PoisonGas : Move //毒瓦斯
    {
        public PoisonGas()
        {
            MoveName = "Poison Gas";

            Type = new Type.Poison();

            Category = new Category.StatusMove();

            PpDefault = 40;
            
            PpCurrent = PpDefault;

            Accuracy = 55;
        }
        
        public override int SetStatusCondition(Pokemon myPokemon, Pokemon yourPokemon)
        {
            battlePVE.battleInformation += yourPokemon.SpeciesName1 + " is Poison!\n";
            battlePVP.battleInformation += yourPokemon.SpeciesName1 + " is Poison!\n";
            yourPokemon.LastReceived1 = this;
            yourPokemon.StatusCondition1 = new StatusCondition.Poison();
            return 11;
        }
    }
}