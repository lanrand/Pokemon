using System;
using Player.HomeScript;
using UnityEngine;

namespace Scripts
{
    public class HomeDoor : MonoBehaviour
    {
        public GameObject home;
        public GameObject choose;
        public GameObject choseModel;
        private void OnMouseDown()
        {
            home.SetActive(true);
            choose.SetActive(true);
            HomeShow homeShow = home.GetComponent<HomeShow>();
            changePokemon changePokemon = choseModel.GetComponent<changePokemon>();
            changePokemon.setShow();
            homeShow.first();
        }
    }
}