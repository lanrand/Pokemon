using Pokemon.Move.Category;
using Pokemon.State;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.SpecialMove
{
    public class SolarBeam : Move //日光束
    {
        public SolarBeam()
        {
            MoveName = "Solar Beam";

            Type = new Grass();

            Category = new Category.SpecialMove();

            PpDefault = 10;

            PpCurrent = PpDefault;

            Power = 200;

            Accuracy = 100;
        }

        public override int UseMove(Pokemon myPokemon, Pokemon yourPokemon)
        {
            myPokemon.LastUse1 = this;
            PpCurrent--;
            if (PpCurrent == 0)
                Available = false;
            SetState(myPokemon, yourPokemon);
            return 0;
        }

        public override int SetState(Pokemon myPokemon, Pokemon yourPokemon)
        {
            myPokemon.CurrentStates1.Add(new Stockpile(new SolarBeamAttack()));
            for (int i = 0; i < myPokemon.CurrentMoves1.Length; i++)
                myPokemon.CurrentMoves1[i].Available1 = false;
            return 4;
        }
    }
}