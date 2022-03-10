using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Pidgeot : Pokemon//大比鸟
    {
        public Pidgeot()
        {
            Number = 12;

            SpeciesName = "Pidgeot";

            Type = new Flying();

            LvMove.Add(0, new Gust());
            LvMove.Add(5, new SandAttack());
            LvMove.Add(12, new QuickAttack());
            LvMove.Add(31, new WingAttack());
            LvMove.Add(44, new Agility());
            LvMove.Add(54, new MirrorMove());

            SpeciesStrength[0] = 83;
            SpeciesStrength[1] = 80;
            SpeciesStrength[2] = 75;
            SpeciesStrength[3] = 70;
            SpeciesStrength[4] = 70;
            SpeciesStrength[5] = 91;

            ExpSpeed = new Slow();;

            CatchRate = 45;
        
            EvolutionLv = 999;

            MinLv = 36;

            BasicExperience = 172;
        }

    }
}