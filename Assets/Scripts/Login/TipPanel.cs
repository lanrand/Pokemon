using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class TipPanel : MonoBehaviour
{
    public Text InfoText;

    void Start()
    {
    }

    public void Show(string message)
    {
        InfoText.text = message;
        gameObject.SetActive(true);
    }

    private void Hide(Unit unit)
    {
        InfoText.text = string.Empty;
        gameObject.SetActive(false);
    }


}