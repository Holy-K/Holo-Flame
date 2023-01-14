using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScaleChanger : MonoBehaviour
{
    public GameObject Flame;
    public SerialHandler serialHandler;
    int fuelCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        serialHandler.OnDataReceived += OnDataReceived;
    }    

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = Flame.transform.localScale;

        //炎サイズの矢印キー＆マウスボタン制御
        if (Input.GetKey("up")|| Input.GetMouseButton(0))
        {
            scale += new Vector3(0.001f, 0.001f, 0.001f);
            Flame.transform.localScale = scale;
           
        }
        if (Input.GetKey("down") || Input.GetMouseButton(1))
        {
            if (scale.y > 0)
            {
                scale -= new Vector3(0.001f, 0.001f, 0.001f);
                Flame.transform.localScale = scale;
            }
        }

        //炎サイズの数字キー制御
        if (Input.GetKey("0")||Input.GetMouseButton(2))
        {
            scale = new Vector3(0, 0, 0);
            Flame.transform.localScale = scale;
        }
        if (Input.GetKey("1"))
        {
            scale = new Vector3(1, 1, 1);
            Flame.transform.localScale = scale;
        }
        if (Input.GetKey("2"))
        {
            scale = new Vector3(2, 2, 2);
            Flame.transform.localScale = scale;
        }
        if (Input.GetKey("3"))
        {
            scale = new Vector3(3, 3, 3);
            Flame.transform.localScale = scale;
        }
        if (Input.GetKey("4"))
        {
            scale = new Vector3(4, 4, 4);
            Flame.transform.localScale = scale;
        }
        if (Input.GetKey("5"))
        {
            scale = new Vector3(5, 5, 5);
            Flame.transform.localScale = scale;
        }
        if (Input.GetKey("6"))
        {
            scale = new Vector3(6, 6, 6);
            Flame.transform.localScale = scale;
        }
        if (Input.GetKey("7"))
        {
            scale = new Vector3(7, 7, 7);
            Flame.transform.localScale = scale;
        }
        if (Input.GetKey("8"))
        {
            scale = new Vector3(8, 8, 8);
            Flame.transform.localScale = scale;
        }
        if (Input.GetKey("9"))
        {
            scale = new Vector3(9, 9, 9);
            Flame.transform.localScale = scale;
        }

        //fuelCount分のフレームの間火力up
        if (fuelCount > 0)
        {
            scale += new Vector3(0.01f, 0.01f, 0.01f);
            Flame.transform.localScale = scale;
            fuelCount -= 1;
        }

        if (scale.x > 1)
        {
            scale -= new Vector3(0.0003f*scale.x * scale.x, 0.0003f * scale.x * scale.x, 0.0003f * scale.x * scale.x);
            Flame.transform.localScale = scale;
        }

        //炎の表示非表示制御
        if (scale.y <= 0)
        {
            Flame.gameObject.SetActive(false);//非表示
            scale = new Vector3(0, 0, 0);
            Flame.transform.localScale = scale;
        }
        else 
        {
            Flame.gameObject.SetActive(true);//表示
        }
    }

    //炎サイズのマイク制御
    void OnDataReceived(string message)
    {
        Vector3 scale = Flame.transform.localScale;
        var data = message.Split(
               new string[] { "\n" }, System.StringSplitOptions.None);
        double number = double.Parse(data[0]);
        if (scale.x > 0 && number >= 2.55)
        {
            fuelCount += 10;

        }
        if (scale.x == 0 && number >= 2.8)
        {
            fuelCount += 10;
        }
    }
}
