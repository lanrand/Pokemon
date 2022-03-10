using Pokemon.Move.Category;
using Pokemon.Type;
using Pokemon.State;
using UnityEngine;

namespace Pokemon.Move.StatusMove
{
    public class MirrorMove : Move //鹦鹉学舌
    {
        public MirrorMove()
        {
            MoveName = "Mirror Move";

            Type = new Flying();

            Category = new Category.StatusMove();

            PpDefault = 20;
            
            PpCurrent = PpDefault;

            Accuracy = 900;
        }
        
        public override int UseMove(Pokemon myPokemon, Pokemon yourPokemon)
        {
            battlePVE.battleInformation += myPokemon.SpeciesName1 + " use the Lasted Move!\n";
            battlePVP.battleInformation += myPokemon.SpeciesName1 + " use the Lasted Move!\n";
            if (myPokemon.LastReceived1 != null&& myPokemon.LastReceived1.MoveName1 != null)
            {
                myPokemon.LastReceived1.UseMove(myPokemon, yourPokemon);
                myPokemon.LastReceived1.PpCurrent1++;
                PpCurrent--;
            }
            return 0;
        }
    }
}