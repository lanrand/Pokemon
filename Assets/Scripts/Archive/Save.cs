using System;
using System.Reflection;
using UnityEngine;

namespace Archive
{
    public class Save : MonoBehaviour
    {
        private User _currentUser;

        private AccountController.AccountController _accountController;
        
        private Archive _currentArchive;

        private Player.Player _player;

        public Player.Player Player
        {
            get => _player;
            set => _player = value;
        }

        public User CurrentUser
        {
            get => _currentUser;
            set => _currentUser = value;
        }

        public Archive CurrentArchive
        {
            get => _currentArchive;
            set => _currentArchive = value;
        }


        public void OnMouseDown()
        {
            //_currentArchive = GameObject.Find("AccountController").GetComponent<AccountController.AccountController>()
            //.CurrentArchive;
            //string path = this._currentArchive.Path;
            //Player.Player player = GameObject.Find("Pokemon").gameObject.GetComponent<Player.Player>();
            ReSetUser();
            string path = Application.dataPath + "/Save/" + _currentUser.Account + "/Data.sav";
            IOHelper.SetData(path, _currentUser);
            Debug.Log("Save");
        }

        public void ReSetUser()
        {
            _accountController = GameObject.Find("AccountController").GetComponent<AccountController.AccountController>();
            _currentUser = _accountController.User;
            _currentArchive = _currentUser.Archives;
            _player = GameObject.Find("Pokemon").gameObject.GetComponent<Player.Player>();
            
            
            _currentArchive.ArchivePlayer.SpeedMove = _player.speed_move;
            _currentArchive.ArchivePlayer.Home = _player.Home;
            _currentArchive.ArchivePlayer.Money = _player.Money;
            _currentArchive.ArchivePlayer.BackpackStuff = _player.BackpackStuff.ConvertToArchiveBackPackStuff();
            _currentArchive.ArchivePlayer.PlayerName = _player.PlayerName;
            _currentArchive.ArchivePlayer.BackPackPokemon = _player.BackPackPokemon;
            _currentArchive.ArchivePlayer.CurrentPokemonList = _player.CurrentPokemonList;
        }
        public static T DeepCopyByReflection<T>(T obj)
        {
            if (obj is string || obj.GetType().IsValueType)
                return obj;

            object retval = Activator.CreateInstance(obj.GetType());
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Static|BindingFlags.Instance);
            foreach(var field in fields)
            {
                try
                {
                    field.SetValue(retval, DeepCopyByReflection(field.GetValue(obj)));
                }
                catch { }
            }

            return (T)retval;
        }

        private void Start()
        {
        }
    }
}