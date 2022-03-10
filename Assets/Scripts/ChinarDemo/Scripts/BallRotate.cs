using System.Collections;
using UnityEngine;


/// <summary>
/// 改变球体颜色
/// </summary>
public class BallRotate : MonoBehaviour
{
    private Material deMaterial;         //默认材质
    public  float    speed       = 10f;  //渐变速度
    public  float    rotateSpeed = 360f; //旋转速度


    void Start()
    {
        deMaterial = GetComponent<MeshRenderer>().material;
        InvokeRepeating("ChangeColor", 1, 1);
    }


    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); //自转
    }


    /// <summary>
    /// 随机颜色
    /// </summary>
    /// <returns> Color </returns>
    private Color RandomColor()
    {
        float r     = Random.Range(0f, 1f);
        float g     = Random.Range(0f, 1f);
        float b     = Random.Range(0f, 1f);
        Color color = new Color(r, g, b);
        return color;
    }


    /// <summary>
    /// 改变颜色
    /// </summary>
    private void ChangeColor()
    {
        StopAllCoroutines();
        Color temColor = RandomColor();
        StartCoroutine(ColorEnumerator(temColor));
    }


    /// <summary>
    /// 开启协程 —— 循环颜色
    /// </summary>
    /// <returns></returns>
    IEnumerator ColorEnumerator(Color temColor)
    {
        while (true) //死循环
        {
            deMaterial.color = Color.Lerp(deMaterial.color, temColor, speed * Time.deltaTime); //插值
            yield return 10;                                                                   //每次暂停10帧
        }
    }
}