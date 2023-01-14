using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowSize : MonoBehaviour
{
   public GameObject targetObject;
   public TextMeshProUGUI sizeObject = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sizeObject.text = targetObject.transform.localScale.x.ToString();
        
    }
}
