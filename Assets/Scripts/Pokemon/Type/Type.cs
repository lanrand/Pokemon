using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Pokemon.Type
{
    public class Type
    {
        protected string _typeName;
        protected ArrayList _superEffective; //2
        protected ArrayList _effective; //1
        protected ArrayList _notVeryEffective; //1/2
        protected ArrayList _notEffective; //0

        // public Type(string typename)
        // { 
        //     _typeName = typename;
        //     _superEffective = new ArrayList();
        //     _effective = new ArrayList();
        //     _notVeryEffective = new ArrayList();
        //     _notEffective = new ArrayList();
        // }


        public string TypeName
        {
            get => _typeName;
            set => _typeName = value;
        }

        public ArrayList SuperEffective
        {
            get => _superEffective;
            set => _superEffective = value;
        }

        public ArrayList Effective
        {
            get => _effective;
            set => _effective = value;
        }

        public ArrayList NotVeryEffective
        {
            get => _notVeryEffective;
            set => _notVeryEffective = value;
        }

        public ArrayList NotEffective
        {
            get => _notEffective;
            set => _notEffective = value;
        }


        public double TypeEffect(Type yourType)
        {
            if (_superEffective.Contains(yourType._typeName))
            {
                battlePVE.battleInformation += "Super Effective!\n";
                battlePVP.battleInformation += "Super Effective!\n";
                return 2;
            }
            if (_effective.Contains(yourType._typeName))
            {
                battlePVE.battleInformation += "Effective!\n";
                battlePVP.battleInformation += "Effective!\n";
                return 1;
            }
            if (_notVeryEffective.Contains(yourType._typeName))
            {
                battlePVE.battleInformation += "Not Very Effective...\n";
                battlePVP.battleInformation += "Not Very Effective...\n";
                return 0.5;
            }
            return 0;
        }

    }

    //
    // public class LoadTypeModule
    // {
    //     private Type _flying = new Type("Flying");
    //     private Type _poison = new Type("Poison");
    //     private Type _fire = new Type("Fire");
    //     private Type _water = new Type("Water");
    //     private Type _grass = new Type("Grass");
    //     private Type _electric = new Type("Electric");
    //     private Dictionary<string, Type> _typeDictionary = new Dictionary<string, Type>();
    //
    //     public Dictionary<string, Type> TypeDictionary
    //     {
    //         get => _typeDictionary;
    //         //set => _typeDictionary = value;
    //     }
    //
    //     public Type Flying
    //     {
    //         get => _flying;
    //         //set => _flying = value;
    //     }
    //
    //     public Type Poison
    //     {
    //         get => _poison;
    //         //set => _poison = value;
    //     }
    //
    //     public Type Fire
    //     {
    //         get => _fire;
    //         //set => _fire = value;
    //     }
    //
    //     public Type Water
    //     {
    //         get => _water;
    //         //set => _water = value;
    //     }
    //
    //     public Type Grass
    //     {
    //         get => _grass;
    //         //set => _grass = value;
    //     }
    //
    //     public Type Electric
    //     {
    //         get => _electric;
    //         //set => _electric = value;
    //     }
    //
    //
    //     public LoadTypeModule()
    //     {
    //         LoadFlying();
    //         LoadPoison();
    //         LoadFire();
    //         LoadWater();
    //         LoadGrass();
    //         LoadElectric();
    //     }
    //     
    //     public void LoadFlying()
    //     {
    //         _water.Effective.Add(_flying);
    //         _water.Effective.Add(_poison);
    //         _water.Effective.Add(_fire);
    //         _water.Effective.Add(_water);
    //         _water.SuperEffective.Add(_grass);
    //         _water.NotVeryEffective.Add(_electric);
    //         _typeDictionary.Add(_flying.TypeName,_flying);
    //     }
    //     
    //     public void LoadPoison()
    //     {
    //         _water.Effective.Add(_flying);
    //         _water.NotVeryEffective.Add(_poison);
    //         _water.Effective.Add(_fire);
    //         _water.Effective.Add(_water);
    //         _water.SuperEffective.Add(_grass);
    //         _water.Effective.Add(_electric);
    //         _typeDictionary.Add(_poison.TypeName,_poison);
    //     }
    //     
    //     public void LoadFire()
    //     {
    //         _fire.Effective.Add(_flying);
    //         _fire.Effective.Add(_poison);
    //         _fire.NotVeryEffective.Add(_fire);
    //         _fire.NotVeryEffective.Add(_water);
    //         _fire.SuperEffective.Add(_grass);
    //         _fire.Effective.Add(_electric);
    //         _typeDictionary.Add(_fire.TypeName,_fire);
    //     }
    //     
    //     public void LoadWater()
    //     {
    //         _water.Effective.Add(_flying);
    //         _water.Effective.Add(_poison);
    //         _water.SuperEffective.Add(_fire);
    //         _water.NotVeryEffective.Add(_water);
    //         _water.NotVeryEffective.Add(_grass);
    //         _water.Effective.Add(_electric);
    //         _typeDictionary.Add(_water.TypeName,_water);
    //     }
    //     
    //     public void LoadGrass()
    //     {
    //         _grass.NotVeryEffective.Add(_flying);
    //         _grass.NotVeryEffective.Add(_poison);
    //         _grass.NotVeryEffective.Add(_fire);
    //         _grass.SuperEffective.Add(_water);
    //         _grass.NotVeryEffective.Add(_grass);
    //         _grass.Effective.Add(_electric);
    //         _typeDictionary.Add(_grass.TypeName,_grass);
    //
    //     }
    //     
    //     public void LoadElectric()
    //     {
    //         _water.SuperEffective.Add(_flying);
    //         _water.Effective.Add(_poison);
    //         _water.Effective.Add(_fire);
    //         _water.SuperEffective.Add(_water);
    //         _water.NotVeryEffective.Add(_grass);
    //         _water.NotVeryEffective.Add(_electric);
    //         _typeDictionary.Add(_electric.TypeName,_electric);
    //     }
    // }
}