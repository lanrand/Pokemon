using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Pokemon.State
{
    public class LeechSeed : State//寄生种子
    {
        public LeechSeed()
        {
            StateName = "Leech Seed";
            //吸1/8HP，对草系无效
        }

        public override int AfterAction(Pokemon myPokemon, Pokemon yourPokemon)
        {
            myPokemon.HpCurrent1 -= myPokemon.HpDefault1/8;
            yourPokemon.HpCurrent1 += myPokemon.HpDefault1 / 8;
            battlePVE.battleInformation += myPokemon.SpeciesName1 + " lose "+ myPokemon.HpDefault1 / 8+" HP!\n";
            battlePVE.battleInformation += yourPokemon.SpeciesName1 + " increase "+ yourPokemon.HpDefault1 / 8+ "HP!\n";
            battlePVP.battleInformation += myPokemon.SpeciesName1 + " lose " + myPokemon.HpDefault1 / 8 + " HP!\n";
            battlePVP.battleInformation += yourPokemon.SpeciesName1 + " increase " + yourPokemon.HpDefault1 / 8 + " HP!\n";
            if (yourPokemon.HpCurrent1 >= yourPokemon.HpDefault1)
                yourPokemon.HpCurrent1 = yourPokemon.HpDefault1;
            if (myPokemon.HpCurrent1 <= 0)
                myPokemon.HpCurrent1 = 0;
            return myPokemon.HpCurrent1;
        }
    }
}