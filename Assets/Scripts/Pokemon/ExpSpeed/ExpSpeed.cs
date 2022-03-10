using System.Collections.Generic;
using UnityEngine;

namespace Pokemon.ExpSpeed
{
    public class ExpSpeed
    {
        protected string _speedRating;
        protected int[] _expAccumulate = new int[101];
        
        public string SpeedRating
        {
            get => _speedRating;
            set => _speedRating = value;
        }
        
        public int[] ExpAccumulate
        {
            get => _expAccumulate;
            set => _expAccumulate = value;
        }
    }

    //
    // public class LoadExpSpeedModule
    // {
    //     private ExpSpeed _fast = new ExpSpeed("Fast");//皮卡丘，臭臭泥
    //     private ExpSpeed _slow = new ExpSpeed("Slow");//妙蛙，火龙，龟龟，比比鸟
    //     private Dictionary<string, ExpSpeed> _expSpeedDictionary = new Dictionary<string, ExpSpeed>();
    //
    //     public ExpSpeed Fast
    //     {
    //         get => _fast;
    //         set => _fast = value;
    //     }
    //
    //     public ExpSpeed Slow
    //     {
    //         get => _slow;
    //         set => _slow = value;
    //     }
    //
    //     public Dictionary<string, ExpSpeed> ExpSpeedDictionary
    //     {
    //         get => _expSpeedDictionary;
    //         set => _expSpeedDictionary = value;
    //     }
    //
    //     public LoadExpSpeedModule()
    //     {
    //         LoadFast(); 
    //         LoadSlow();
    //     }
    //
    //     public void LoadFast()
    //     {
    //         _fast.ExpAccumulate[0] = 0;
    //         _fast.ExpAccumulate[1] = 8;
    //         _fast.ExpAccumulate[2] = 27;
    //         _fast.ExpAccumulate[3] = 64;
    //         _fast.ExpAccumulate[4] = 125;
    //         _fast.ExpAccumulate[5] = 216;
    //         _fast.ExpAccumulate[6] = 343;
    //         _fast.ExpAccumulate[7] = 512;
    //         _fast.ExpAccumulate[8] = 729;
    //         _fast.ExpAccumulate[9] = 1000;
    //         _fast.ExpAccumulate[10] = 1331;
    //         _fast.ExpAccumulate[11] = 1728;
    //         _fast.ExpAccumulate[12] = 2197;
    //         _fast.ExpAccumulate[13] = 2744;
    //         _fast.ExpAccumulate[14] = 3375;
    //         _fast.ExpAccumulate[15] = 4096;
    //         _fast.ExpAccumulate[16] = 4913;
    //         _fast.ExpAccumulate[17] = 5832;
    //         _fast.ExpAccumulate[18] = 6859;
    //         _fast.ExpAccumulate[19] = 8000;
    //         _fast.ExpAccumulate[20] = 9261;
    //         _fast.ExpAccumulate[21] = 10648;
    //         _fast.ExpAccumulate[22] = 12167;
    //         _fast.ExpAccumulate[23] = 13824;
    //         _fast.ExpAccumulate[24] = 15625;
    //         _fast.ExpAccumulate[25] = 17576;
    //         _fast.ExpAccumulate[26] = 19683;
    //         _fast.ExpAccumulate[27] = 21952;
    //         _fast.ExpAccumulate[28] = 24389;
    //         _fast.ExpAccumulate[29] = 27000;
    //         _fast.ExpAccumulate[30] = 29791;
    //         _fast.ExpAccumulate[31] = 32768;
    //         _fast.ExpAccumulate[32] = 35937;
    //         _fast.ExpAccumulate[33] = 39304;
    //         _fast.ExpAccumulate[34] = 42875;
    //         _fast.ExpAccumulate[35] = 46656;
    //         _fast.ExpAccumulate[36] = 50653;
    //         _fast.ExpAccumulate[37] = 54872;
    //         _fast.ExpAccumulate[38] = 59319;
    //         _fast.ExpAccumulate[39] = 64000;
    //         _fast.ExpAccumulate[40] = 68921;
    //         _fast.ExpAccumulate[41] = 74088;
    //         _fast.ExpAccumulate[42] = 79507;
    //         _fast.ExpAccumulate[43] = 85184;
    //         _fast.ExpAccumulate[44] = 91125;
    //         _fast.ExpAccumulate[45] = 97336;
    //         _fast.ExpAccumulate[46] = 103823;
    //         _fast.ExpAccumulate[47] = 110592;
    //         _fast.ExpAccumulate[48] = 117649;
    //         _fast.ExpAccumulate[49] = 125000;
    //         _fast.ExpAccumulate[50] = 132651;
    //         _fast.ExpAccumulate[51] = 140608;
    //         _fast.ExpAccumulate[52] = 148877;
    //         _fast.ExpAccumulate[53] = 157464;
    //         _fast.ExpAccumulate[54] = 166375;
    //         _fast.ExpAccumulate[55] = 175616;
    //         _fast.ExpAccumulate[56] = 185193;
    //         _fast.ExpAccumulate[57] = 195112;
    //         _fast.ExpAccumulate[58] = 205379;
    //         _fast.ExpAccumulate[59] = 216000;
    //         _fast.ExpAccumulate[60] = 226981;
    //         _fast.ExpAccumulate[61] = 238328;
    //         _fast.ExpAccumulate[62] = 250047;
    //         _fast.ExpAccumulate[63] = 262144;
    //         _fast.ExpAccumulate[64] = 274625;
    //         _fast.ExpAccumulate[65] = 287496;
    //         _fast.ExpAccumulate[66] = 300763;
    //         _fast.ExpAccumulate[67] = 314432;
    //         _fast.ExpAccumulate[68] = 328509;
    //         _fast.ExpAccumulate[69] = 343000;
    //         _fast.ExpAccumulate[70] = 357911;
    //         _fast.ExpAccumulate[71] = 373248;
    //         _fast.ExpAccumulate[72] = 389017;
    //         _fast.ExpAccumulate[73] = 405224;
    //         _fast.ExpAccumulate[74] = 421875;
    //         _fast.ExpAccumulate[75] = 438976;
    //         _fast.ExpAccumulate[76] = 456533;
    //         _fast.ExpAccumulate[77] = 474552;
    //         _fast.ExpAccumulate[78] = 493039;
    //         _fast.ExpAccumulate[79] = 512000;
    //         _fast.ExpAccumulate[80] = 531441;
    //         _fast.ExpAccumulate[81] = 551368;
    //         _fast.ExpAccumulate[82] = 571787;
    //         _fast.ExpAccumulate[83] = 592704;
    //         _fast.ExpAccumulate[84] = 614125;
    //         _fast.ExpAccumulate[85] = 636056;
    //         _fast.ExpAccumulate[86] = 658503;
    //         _fast.ExpAccumulate[87] = 681472;
    //         _fast.ExpAccumulate[88] = 704969;
    //         _fast.ExpAccumulate[89] = 729000;
    //         _fast.ExpAccumulate[90] = 753571;
    //         _fast.ExpAccumulate[91] = 778688;
    //         _fast.ExpAccumulate[92] = 804357;
    //         _fast.ExpAccumulate[93] = 830584;
    //         _fast.ExpAccumulate[94] = 857375;
    //         _fast.ExpAccumulate[95] = 884736;
    //         _fast.ExpAccumulate[96] = 912673;
    //         _fast.ExpAccumulate[97] = 941192;
    //         _fast.ExpAccumulate[98] = 970299;
    //         _fast.ExpAccumulate[99] = 1000000;
    //         _expSpeedDictionary.Add(_fast.SpeedRating,_fast);
    //     }
    //
    //     public void LoadSlow()
    //     {
    //         _slow.ExpAccumulate[0] = 0;
    //         _slow.ExpAccumulate[1] = 9;
    //         _slow.ExpAccumulate[2] = 57;
    //         _slow.ExpAccumulate[3] = 96;
    //         _slow.ExpAccumulate[4] = 135;
    //         _slow.ExpAccumulate[5] = 179;
    //         _slow.ExpAccumulate[6] = 236;
    //         _slow.ExpAccumulate[7] = 314;
    //         _slow.ExpAccumulate[8] = 419;
    //         _slow.ExpAccumulate[9] = 560;
    //         _slow.ExpAccumulate[10] = 742;
    //         _slow.ExpAccumulate[11] = 973;
    //         _slow.ExpAccumulate[12] = 1261;
    //         _slow.ExpAccumulate[13] = 1612;
    //         _slow.ExpAccumulate[14] = 2035;
    //         _slow.ExpAccumulate[15] = 2535;
    //         _slow.ExpAccumulate[16] = 3120;
    //         _slow.ExpAccumulate[17] = 3798;
    //         _slow.ExpAccumulate[18] = 4575;
    //         _slow.ExpAccumulate[19] = 5460;
    //         _slow.ExpAccumulate[20] = 6458;
    //         _slow.ExpAccumulate[21] = 7577;
    //         _slow.ExpAccumulate[22] = 8825;
    //         _slow.ExpAccumulate[23] = 10208;
    //         _slow.ExpAccumulate[24] = 11735;
    //         _slow.ExpAccumulate[25] = 13411;
    //         _slow.ExpAccumulate[26] = 15244;
    //         _slow.ExpAccumulate[27] = 17242;
    //         _slow.ExpAccumulate[28] = 19411;
    //         _slow.ExpAccumulate[29] = 21760;
    //         _slow.ExpAccumulate[30] = 24294;
    //         _slow.ExpAccumulate[31] = 27021;
    //         _slow.ExpAccumulate[32] = 29949;
    //         _slow.ExpAccumulate[33] = 33084;
    //         _slow.ExpAccumulate[34] = 36435;
    //         _slow.ExpAccumulate[35] = 40007;
    //         _slow.ExpAccumulate[36] = 43808;
    //         _slow.ExpAccumulate[37] = 47846;
    //         _slow.ExpAccumulate[38] = 52127;
    //         _slow.ExpAccumulate[39] = 56660;
    //         _slow.ExpAccumulate[40] = 61450;
    //         _slow.ExpAccumulate[41] = 66505;
    //         _slow.ExpAccumulate[42] = 71833;
    //         _slow.ExpAccumulate[43] = 77440;
    //         _slow.ExpAccumulate[44] = 83335;
    //         _slow.ExpAccumulate[45] = 89523;
    //         _slow.ExpAccumulate[46] = 96012;
    //         _slow.ExpAccumulate[47] = 102810;
    //         _slow.ExpAccumulate[48] = 109923;
    //         _slow.ExpAccumulate[49] = 117360;
    //         _slow.ExpAccumulate[50] = 125126;
    //         _slow.ExpAccumulate[51] = 133229;
    //         _slow.ExpAccumulate[52] = 141677;
    //         _slow.ExpAccumulate[53] = 150476;
    //         _slow.ExpAccumulate[54] = 159635;
    //         _slow.ExpAccumulate[55] = 169159;
    //         _slow.ExpAccumulate[56] = 179056;
    //         _slow.ExpAccumulate[57] = 189334;
    //         _slow.ExpAccumulate[58] = 199999;
    //         _slow.ExpAccumulate[59] = 211060;
    //         _slow.ExpAccumulate[60] = 222522;
    //         _slow.ExpAccumulate[61] = 234393;
    //         _slow.ExpAccumulate[62] = 246681;
    //         _slow.ExpAccumulate[63] = 259392;
    //         _slow.ExpAccumulate[64] = 272535;
    //         _slow.ExpAccumulate[65] = 286115;
    //         _slow.ExpAccumulate[66] = 300140;
    //         _slow.ExpAccumulate[67] = 314618;
    //         _slow.ExpAccumulate[68] = 329555;
    //         _slow.ExpAccumulate[69] = 344960;
    //         _slow.ExpAccumulate[70] = 360838;
    //         _slow.ExpAccumulate[71] = 377197;
    //         _slow.ExpAccumulate[72] = 394045;
    //         _slow.ExpAccumulate[73] = 411388;
    //         _slow.ExpAccumulate[74] = 429235;
    //         _slow.ExpAccumulate[75] = 447591;
    //         _slow.ExpAccumulate[76] = 466464;
    //         _slow.ExpAccumulate[77] = 485862;
    //         _slow.ExpAccumulate[78] = 505791;
    //         _slow.ExpAccumulate[79] = 526260;
    //         _slow.ExpAccumulate[80] = 547274;
    //         _slow.ExpAccumulate[81] = 568841;
    //         _slow.ExpAccumulate[82] = 590969;
    //         _slow.ExpAccumulate[83] = 613664;
    //         _slow.ExpAccumulate[84] = 636935;
    //         _slow.ExpAccumulate[85] = 660787;
    //         _slow.ExpAccumulate[86] = 685228;
    //         _slow.ExpAccumulate[87] = 710266;
    //         _slow.ExpAccumulate[88] = 735907;
    //         _slow.ExpAccumulate[89] = 762160;
    //         _slow.ExpAccumulate[90] = 789030;
    //         _slow.ExpAccumulate[91] = 816525;
    //         _slow.ExpAccumulate[92] = 844653;
    //         _slow.ExpAccumulate[93] = 873420;
    //         _slow.ExpAccumulate[94] = 902835;
    //         _slow.ExpAccumulate[95] = 932903;
    //         _slow.ExpAccumulate[96] = 963632;
    //         _slow.ExpAccumulate[97] = 995030;
    //         _slow.ExpAccumulate[98] = 1027103;
    //         _slow.ExpAccumulate[99] = 1059860;
    //         _expSpeedDictionary.Add(_slow.SpeedRating,_slow);
    //     }
    //
    // }
}