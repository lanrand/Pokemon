using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Move.PhysicalMove;
using Pokemon.Move.SpecialMove;
using Pokemon.Move.StatusMove;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Wartortle : Pokemon//卡咪龟
    {
        public Wartortle()
        {
            Number = 8;

            SpeciesName = "Wartortle";

            Type = new Water();

            LvMove.Add(-1, new Tackle());
            LvMove.Add(0, new TailWhip());
            LvMove.Add(8, new Bubble());
            LvMove.Add(15, new WaterGun());
            LvMove.Add(24, new Bite());
            LvMove.Add(31, new Withdraw());

            SpeciesStrength[0] = 59;
            SpeciesStrength[1] = 63;
            SpeciesStrength[2] = 80;
            SpeciesStrength[3] = 65;
            SpeciesStrength[4] = 80;
            SpeciesStrength[5] = 58;

            ExpSpeed = new Slow();

            CatchRate = 45;
        
            EvolutionLv = 36;

            MinLv = 16;

            BasicExperience = 143;
        }

        public override Pokemon Evolution()
        {
            Pokemon newPokemon = new Blastoise();

            return newPokemon;
        }

    }
}