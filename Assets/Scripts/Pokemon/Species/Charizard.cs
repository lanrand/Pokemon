using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Charizard : Pokemon//喷火龙
    {
        public Charizard()
        {
            Number = 6;

            SpeciesName = "Charizard";

            Type = new Fire();

            LvMove.Add(-1, new Scratch());
            LvMove.Add(0, new Growl());
            LvMove.Add(9, new Ember());
            LvMove.Add(15, new Leer());
            LvMove.Add(22, new Rage());
            LvMove.Add(33, new Slash());
            LvMove.Add(46, new Flamethrower());
            LvMove.Add(55, new FireSpin());

            SpeciesStrength[0] = 78;
            SpeciesStrength[1] = 84;
            SpeciesStrength[2] = 78;
            SpeciesStrength[3] = 109;
            SpeciesStrength[4] = 85;
            SpeciesStrength[5] = 100;

            ExpSpeed = new Slow();

            CatchRate = 45;
       
            EvolutionLv = 999;

            MinLv = 36;

            BasicExperience = 209;
        }

    }
}