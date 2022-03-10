using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Ivysaur : Pokemon//妙蛙草
    {
        public Ivysaur()
        {
            Number = 2;

            SpeciesName = "Ivysaur";

            Type = new Grass();

            LvMove.Add(-1, new Tackle());
            LvMove.Add(0, new Growl());
            LvMove.Add(7, new LeechSeed());
            LvMove.Add(13, new VineWhip());
            LvMove.Add(22, new PoisonPowder());
            LvMove.Add(30, new RazorLeaf());

            SpeciesStrength[0] = 60;
            SpeciesStrength[1] = 62;
            SpeciesStrength[2] = 63;
            SpeciesStrength[3] = 80;
            SpeciesStrength[4] = 80;
            SpeciesStrength[5] = 60;

            ExpSpeed = new Slow();

            CatchRate = 45;
        
            EvolutionLv = 32;

            MinLv = 16;

            BasicExperience = 141;
        }

        public override Pokemon Evolution()
        {
            Pokemon newPokemon = new Venusaur();

            return newPokemon;
        }

    }
}