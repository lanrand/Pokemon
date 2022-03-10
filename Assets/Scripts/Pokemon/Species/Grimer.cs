using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Grimer : Pokemon//臭泥
    {
        public Grimer()
        {
            Number = 15;

            SpeciesName = "Grimer";

            Type = new Type.Poison();

            LvMove.Add(-1, new Pound());
            LvMove.Add(0, new Disable());
            LvMove.Add(30, new PoisonGas());
            LvMove.Add(33, new Minimize());
            LvMove.Add(37, new Sludge());

            SpeciesStrength[0] = 80;
            SpeciesStrength[1] = 80;
            SpeciesStrength[2] = 50;
            SpeciesStrength[3] = 40;
            SpeciesStrength[4] = 50;
            SpeciesStrength[5] = 25;

            ExpSpeed = new Fast();

            CatchRate = 190;
        
            EvolutionLv = 38;

            MinLv = 1;

            BasicExperience = 90;
        }

        public override Pokemon Evolution()
        {
            Pokemon newPokemon = new Muk();
            return newPokemon;
        }

    }
}