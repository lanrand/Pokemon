using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePokemon : MonoBehaviour
{
    GameObject[] model = new GameObject[12];
    GameObject[] shuxing = new GameObject[8];
    GameObject image;
    (int, int) now = (0, 0);
    Vector3 postion1 = new Vector3(-1900, 100,0);
    Vector3 postion2 = new Vector3(-1990, 100,0);
    void Start()
    {
        GameObject temp = transform.Find("model").gameObject;
        int cnt = 0;
        foreach (Transform child in temp.transform)
        {
            model[cnt] = child.gameObject;
            cnt++;
        }
        image = transform.Find("image").gameObject;
        image.transform.localPosition = postion1;
        cnt = 0;
        foreach (Transform child in image.transform)
        {
            shuxing[cnt] = child.gameObject;
            cnt++;
        }

    }

    public void setChoFirst()
    {
        image.transform.position = postion1;
    }

    public void setShow()
    {
        image.transform.localPosition = postion2;
    }

    public void choXiaohuo()
    {
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[0].SetActive(true);
        shuxing[0].SetActive(true);
        now = (0, 0);
    }

    public void choMiaowazhongzi()
    {
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[1].SetActive(true);
        shuxing[1].SetActive(true);
        now = (1, 1);
    }

    public void choJieni()
    {
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[2].SetActive(true);
        shuxing[2].SetActive(true);
        now = (2, 2);
    }

    public void choKami()
    {
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[3].SetActive(true);
        shuxing[2].SetActive(true);
        now = (3, 2);
    }

    public void choMiaowacao()
    {
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[4].SetActive(true);
        shuxing[1].SetActive(true);
        now = (4, 1);
    }

    public void choBibiniao()
    {
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[5].SetActive(true);
        shuxing[6].SetActive(true);
        now = (5, 6);
    }

    public void choBobo()
    {
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[6].SetActive(true);
        shuxing[6].SetActive(true);
        now = (6, 6);
    }

    public void choHuokonglong()
    {
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[7].SetActive(true);
        shuxing[1].SetActive(true);
        now = (7, 1);
    }

    public void choPika()
    {
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[8].SetActive(true);
        shuxing[5].SetActive(true);
        now = (8, 5);
    }

    public void choChouni()
    {
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[9].SetActive(true);
        shuxing[4].SetActive(true);
        now = (9, 4);
    }

    public void choChounchouni()
    {
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[10].SetActive(true);
        shuxing[4].SetActive(true);
        now = (10, 4);
    }

    public void choLeiqiu()
    {
        gameObject.SetActive(true);
        gameObject.SetActive(true);
        image.SetActive(true);
        Clear();
        model[11].SetActive(true);
        shuxing[5].SetActive(true);
        now = (11, 5);
    }

    public void Clear()
    {
        image.SetActive(true);
        model[now.Item1].SetActive(false);
        shuxing[now.Item2].SetActive(false);
    }
}
