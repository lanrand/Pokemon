using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Bulbasaur : Pokemon//妙蛙种子
    {
        public Bulbasaur()
        {
            Number = 1;

            SpeciesName = "Bulbasaur";

            Type = new Grass();

            LvMove.Add(-1, new Tackle());
            LvMove.Add(0, new Growl());
            LvMove.Add(7, new LeechSeed());
            LvMove.Add(13, new VineWhip());

            SpeciesStrength[0] = 45;
            SpeciesStrength[1] = 49;
            SpeciesStrength[2] = 49;
            SpeciesStrength[3] = 65;
            SpeciesStrength[4] = 65;
            SpeciesStrength[5] = 45;

            ExpSpeed = new Slow();

            CatchRate = 45;

            EvolutionLv = 16;

            MinLv = 1;

            BasicExperience = 64;
        }

        public override Pokemon Evolution()
        {
            Pokemon newPokemon = new Ivysaur();

            return newPokemon;
        }

    }
}