using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Pidgeotto : Pokemon//比比鸟
    {
        public Pidgeotto()
        {
            Number = 11;

            SpeciesName = "Pidgeotto";

            Type = new Flying();

            LvMove.Add(0, new Gust());
            LvMove.Add(5, new SandAttack());
            LvMove.Add(12, new QuickAttack());
            LvMove.Add(31, new WingAttack());

            SpeciesStrength[0] = 63;
            SpeciesStrength[1] = 60;
            SpeciesStrength[2] = 55;
            SpeciesStrength[3] = 50;
            SpeciesStrength[4] = 50;
            SpeciesStrength[5] = 71;

            ExpSpeed = new Slow();;

            CatchRate = 120;
        
            EvolutionLv = 36;

            MinLv = 18;

            BasicExperience = 113;
        }

        public override Pokemon Evolution()
        {
            Pokemon newPokemon = new Pidgeot();

            return newPokemon;
        }

    }
}