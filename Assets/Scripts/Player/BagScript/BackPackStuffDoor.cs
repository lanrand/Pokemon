using UnityEngine;

namespace Player.BagScript
{
    public class BackPackStuffDoor : MonoBehaviour
    {
        public Canvas bagPage;

        private void Start()
        {
            bagPage.gameObject.SetActive(false);
        }

        private void OnMouseDown()
        {
            if (bagPage.gameObject.activeSelf)
            {
                bagPage.gameObject.SetActive(false);
            }
            else
            {
                bagPage.gameObject.SetActive(true);
                bagPage.transform.Find("StuffBagPanel").GetComponent<BackPackStuffController>().IniBag();
            }
        }
    }
}