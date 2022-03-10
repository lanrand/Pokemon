using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Raichu : Pokemon//雷丘
    {
        public Raichu()
        {
            Number = 14;

            SpeciesName = "Raichu";

            Type = new Electric();

            LvMove.Add(-1, new ThunderShock());
            LvMove.Add(0, new Growl());
            LvMove.Add(6, new TailWhip());
            LvMove.Add(8, new ThunderWave());
            LvMove.Add(11, new QuickAttack());
            LvMove.Add(15, new DoubleTeam());
            LvMove.Add(20, new Slam());
            LvMove.Add(26, new Thunderbolt());
            LvMove.Add(33, new Agility());
            LvMove.Add(41, new Thunder());

            SpeciesStrength[0] = 60;
            SpeciesStrength[1] = 90;
            SpeciesStrength[2] = 55;
            SpeciesStrength[3] = 90;
            SpeciesStrength[4] = 80;
            SpeciesStrength[5] = 100;

            ExpSpeed = new Fast();

            CatchRate = 75;
        
            EvolutionLv = 999;

            MinLv = 38;

            BasicExperience = 122;
        }
        
    }
}