using System;
using UnityEngine;
using UnityEngine.UI;
namespace Login
{
    public class NewGameButton : MonoBehaviour
    {
        private Archive.User _user;
        public void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(CreateArchive);
        }
        
        public void CreateArchive()
        {
            _user = GameObject.Find("AccountController").GetComponent<AccountController.AccountController>().User;
            Archive.Archive archive = new Archive.Archive(_user.Account);
            archive.Path = Application.dataPath + "/save/" + _user.Account + "/Data.sav";
            _user.Archives = archive;
        }
    }
}