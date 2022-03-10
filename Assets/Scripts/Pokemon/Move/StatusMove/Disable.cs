using Pokemon.Move.Category;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.StatusMove
{
    public class Disable : Move //定身法
    {
        public Disable()
        {
            MoveName = "Disable";

            Type = new Type.Normal();

            Category = new Category.StatusMove();

            PpDefault = 20;
            
            PpCurrent = PpDefault;

            Accuracy = 55;
        }
        
        public override int SetState(Pokemon myPokemon, Pokemon yourPokemon)
        {
            battlePVE.battleInformation += yourPokemon.SpeciesName1 + " is Disabled!\n";
            battlePVP.battleInformation += yourPokemon.SpeciesName1 + " is Disabled!\n";
            yourPokemon.LastReceived1 = this;
            yourPokemon.CurrentUse1.Available1 = false;
            State.Disable disable = new State.Disable(yourPokemon.CurrentUse1);
            yourPokemon.CurrentStates1.Add(disable);
            return 11;
        }
    }
}