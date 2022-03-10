using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Blastoise : Pokemon//水箭龟
    {
        public Blastoise()
        {
            Number = 9;

            SpeciesName = "Blastoise";

            Type = new Water();

            LvMove.Add(-1, new Tackle());
            LvMove.Add(0, new TailWhip());
            LvMove.Add(8, new Bubble());
            LvMove.Add(15, new WaterGun());
            LvMove.Add(24, new Bite());
            LvMove.Add(31, new Withdraw());
            LvMove.Add(42, new SkullBash());
            LvMove.Add(52, new HydroPump());

            SpeciesStrength[0] = 79;
            SpeciesStrength[1] = 83;
            SpeciesStrength[2] = 100;
            SpeciesStrength[3] = 85;
            SpeciesStrength[4] = 105;
            SpeciesStrength[5] = 78;

            ExpSpeed = new Slow();

            CatchRate = 45;
        
            EvolutionLv = 999;

            MinLv = 36;

            BasicExperience = 210;
        }

    }
}