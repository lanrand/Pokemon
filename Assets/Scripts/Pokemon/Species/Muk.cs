using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Muk : Pokemon//臭臭泥
    {
        public Muk()
        {
            Number = 16;

            SpeciesName = "Muk";

            Type = new Type.Poison();

            LvMove.Add(-1, new Pound());
            LvMove.Add(0, new Disable());
            LvMove.Add(30, new PoisonGas());
            LvMove.Add(33, new Minimize());
            LvMove.Add(37, new Sludge());
            LvMove.Add(45, new Harden());
            LvMove.Add(53, new Screech());
            LvMove.Add(60, new AcidArmor());

            SpeciesStrength[0] = 105;
            SpeciesStrength[1] = 105;
            SpeciesStrength[2] = 75;
            SpeciesStrength[3] = 65;
            SpeciesStrength[4] = 100;
            SpeciesStrength[5] = 50;

            ExpSpeed = new Fast();;

            CatchRate = 75;
        
            EvolutionLv = 999;

            MinLv = 38;

            BasicExperience = 157;
        }
        
    }
}