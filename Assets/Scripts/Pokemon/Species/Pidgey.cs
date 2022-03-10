using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Pidgey : Pokemon//波波
    {
        public Pidgey()
        {
            Number = 10;

            SpeciesName = "Pidgey";

            Type = new Flying();

            LvMove.Add(0, new Gust());
            LvMove.Add(5, new SandAttack());
            LvMove.Add(12, new QuickAttack());

            SpeciesStrength[0] = 40;
            SpeciesStrength[1] = 45;
            SpeciesStrength[2] = 40;
            SpeciesStrength[3] = 35;
            SpeciesStrength[4] = 35;
            SpeciesStrength[5] = 56;

            ExpSpeed = new Slow();

            CatchRate = 255;
        
            EvolutionLv = 18;

            MinLv = 1;

            BasicExperience = 55;
        }

        public override Pokemon Evolution()
        {
            Pokemon newPokemon = new Pidgeotto();

            return newPokemon;
        }

    }
}