using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Charmander : Pokemon//小火龙
    {
        public Charmander()
        {
            Number = 4;

            SpeciesName = "Charmander";

            Type = new Fire();

            LvMove.Add(-1, new Scratch());
            LvMove.Add(0, new Growl());
            LvMove.Add(9, new Ember());
            LvMove.Add(15, new Leer());
            
            SpeciesStrength[0] = 39;
            SpeciesStrength[1] = 52;
            SpeciesStrength[2] = 43;
            SpeciesStrength[3] = 60;
            SpeciesStrength[4] = 50;
            SpeciesStrength[5] = 65;

            ExpSpeed = new Slow();

            CatchRate = 45;
            
            EvolutionLv = 16;

            MinLv = 1;

            BasicExperience = 65;
        }

        public override Pokemon Evolution()
        {
            Pokemon newPokemon = new Charmeleon();
            return newPokemon;
        }
    }
}