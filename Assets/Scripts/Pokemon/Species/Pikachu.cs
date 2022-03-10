using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            Number = 13;

            SpeciesName = "Pikachu";

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

            SpeciesStrength[0] = 35;
            SpeciesStrength[1] = 55;
            SpeciesStrength[2] = 30;
            SpeciesStrength[3] = 50;
            SpeciesStrength[4] = 40;
            SpeciesStrength[5] = 90;

            ExpSpeed = new Fast();;

            CatchRate = 190;
        
            EvolutionLv = 38;

            MinLv = 1;

            BasicExperience = 82;
        }

        public override Pokemon Evolution()
        {
            Pokemon newPokemon = new Raichu();

            return newPokemon;
        }

    }
}