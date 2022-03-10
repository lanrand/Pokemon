using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Squirtle : Pokemon//杰尼龟
    {
        public Squirtle()
        {
            Number = 7;

            SpeciesName = "Squirtle";

            Type = new Water();

            LvMove.Add(-1, new Tackle());
            LvMove.Add(0, new TailWhip());
            LvMove.Add(8, new Bubble());
            LvMove.Add(15, new WaterGun());

            SpeciesStrength[0] = 44;
            SpeciesStrength[1] = 48;
            SpeciesStrength[2] = 65;
            SpeciesStrength[3] = 50;
            SpeciesStrength[4] = 64;
            SpeciesStrength[5] = 43;

            ExpSpeed = new Slow();

            CatchRate = 45;
        
            EvolutionLv = 16;

            MinLv = 1;

            BasicExperience = 66;
        }

        public override Pokemon Evolution()
        {
            Pokemon newPokemon = new Wartortle();

            return newPokemon;
        }

    }
}