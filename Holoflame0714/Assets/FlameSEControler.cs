using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameSEControler : MonoBehaviour
{
    public GameObject Flame;
    public AudioSource AudioSource_1;
    //public AudioClip SE1;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource_1.Play();
        //AudioSource_1.PlayOneShot(SE1);
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 scale = Flame.transform.localScale;
        if (scale.y <= 2)
        {
            AudioSource_1.volume = scale.y / 2;
        }
    }
}
//ŽQl@https://qiita.com/lycoris102/items/5d5359b2015a8fdebaaa