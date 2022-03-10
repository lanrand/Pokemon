using System;
using UnityEngine;

namespace AccountController
{
    public class AccountController : MonoBehaviour
    {
        public Archive.User User;
        public Archive.Archive CurrentArchive;

        public void Start()
        {
            User = new Archive.User("","");
            CurrentArchive = new Archive.Archive("");
        }
    }
}