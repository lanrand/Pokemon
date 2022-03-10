using Pokemon.Move.Category;
using Pokemon.Type;
using Pokemon.State;
using UnityEngine;

namespace Pokemon.Move.StatusMove
{
    public class LeechSeed : Move //寄生种子
    {
        public LeechSeed()
        {
            MoveName = "Leech Seed";

            Type = new Grass();

            Category = new Category.StatusMove();

            PpDefault = 10;
            
            PpCurrent = PpDefault;

            Accuracy = 90;
        }
        
        public override int SetState(Pokemon myPokemon, Pokemon yourPokemon)
        {
            yourPokemon.LastReceived1 = this;
            yourPokemon.CurrentStates1.Add(new State.LeechSeed());
            return 10;
        }
    }
}