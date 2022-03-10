using UnityEngine;
using UnityEngine.EventSystems;

namespace Shop
{
    public class MouseEvent : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
    {
        public GameObject Information;
        public Item.Item Item;
        
        public void OnPointerEnter(PointerEventData eventData)
        {
            Information.SetActive(true);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            Information.SetActive(false);
        }
    }
}