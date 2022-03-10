using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Venusaur : Pokemon//妙蛙花
    {
        public Venusaur()
        {
            Number = 3;

            SpeciesName = "Venusaur";

            Type = new Grass();

            LvMove.Add(-1, new Tackle());
            LvMove.Add(0, new Growl());
            LvMove.Add(7, new LeechSeed());
            LvMove.Add(13, new VineWhip());
            LvMove.Add(22, new PoisonPowder());
            LvMove.Add(30, new RazorLeaf());
            LvMove.Add(43, new Growth());
            LvMove.Add(55, new SleepPowder());
            LvMove.Add(65, new SolarBeam());

            SpeciesStrength[0] = 80;
            SpeciesStrength[1] = 82;
            SpeciesStrength[2] = 83;
            SpeciesStrength[3] = 100;
            SpeciesStrength[4] = 100;
            SpeciesStrength[5] = 80;

            ExpSpeed = new Slow();

            CatchRate = 45;
            
            EvolutionLv = 999;

            MinLv = 32;

            BasicExperience = 208;
        }
        
    }
}