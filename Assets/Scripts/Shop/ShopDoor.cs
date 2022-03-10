using System;
using UnityEngine;

namespace Shop
{
    public class ShopDoor : MonoBehaviour
    {
        public Canvas shopPage;

        private void Start()
        {
            shopPage.gameObject.SetActive(false);
        }

        private void OnMouseDown()
        {
            if (shopPage.gameObject.activeSelf)
            {
                shopPage.gameObject.SetActive(false);
            }
            else
            {
                shopPage.gameObject.SetActive(true);
            }
        }
    }
}