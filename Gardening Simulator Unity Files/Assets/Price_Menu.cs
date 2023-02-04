using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Price_Menu : MonoBehaviour
{
    public Canvas canvas;
    void Start()
    {
        canvas.enabled = false;
    }

  
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Escape)))
        {
            Debug.Log("yee");
            canvas.enabled = false;
        }

        if ((Input.GetKeyDown(KeyCode.Space)))
        {
            Debug.Log("nee");
            canvas.enabled = true;
        }
    }
}
