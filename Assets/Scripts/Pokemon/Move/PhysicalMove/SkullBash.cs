using Pokemon.Move.Category;
using Pokemon.State;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move.PhysicalMove
{
    public class SkullBash : Move //火箭头锤
    {
        public SkullBash()
        {
            MoveName = "Skull Bash";

            Type = new Normal();

            Category = new Category.PhysicalMove();

            PpDefault = 15;

            PpCurrent = PpDefault;

            Power = 100;

            Accuracy = 100;
        }

        public override int UseMove(Pokemon myPokemon, Pokemon yourPokemon)
        {
            myPokemon.LastUse1 = this;
            PpCurrent--;
            if (PpCurrent == 0)
                Available = false;
            SetState(myPokemon, yourPokemon);
            StatChange(myPokemon, yourPokemon);
            return 0; 
        }

        public override int[] StatChange(Pokemon myPokemon, Pokemon yourPokemon)
        {
            myPokemon.DefenseCurrent1++;
            int[] tmp = {1, 1};
            return tmp;
        }

        public override int SetState(Pokemon myPokemon, Pokemon yourPokemon)
        {
            myPokemon.CurrentStates1.Add(new Stockpile(new SkullBashAttack()));
            for (int i = 0; i < myPokemon.CurrentMoves1.Length; i++)
                myPokemon.CurrentMoves1[i].Available1 = false;
            return 4;
        }
    }
}