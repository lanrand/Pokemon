using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Charmeleon : Pokemon//火恐龙
    {
        public Charmeleon()
        {
            Number = 5;

            SpeciesName = "Charmeleon";

            Type = new Fire();

            LvMove.Add(-1, new Scratch());
            LvMove.Add(0, new Growl());
            LvMove.Add(9, new Ember());
            LvMove.Add(15, new Leer());
            LvMove.Add(22, new Rage());
            LvMove.Add(33, new Slash());

            SpeciesStrength[0] = 58;
            SpeciesStrength[1] = 64;
            SpeciesStrength[2] = 58;
            SpeciesStrength[3] = 80;
            SpeciesStrength[4] = 65;
            SpeciesStrength[5] = 80;

            ExpSpeed = new Slow();

            CatchRate = 45;
            
            EvolutionLv = 36;

            MinLv = 16;

            BasicExperience = 142;
        }

        public override Pokemon Evolution()
        {
            Pokemon newPokemon = new Charizard();
            return newPokemon;
        }

    }
}