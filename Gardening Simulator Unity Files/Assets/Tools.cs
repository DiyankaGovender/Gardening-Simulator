using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools : MonoBehaviour
{
    public Cursor_Mode Cursor_Mode;
    public AudioSource Clickaudio;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.tag == "Axe")
        {
            Tool_Manager.currentTool = "Axe";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().axe();
            Clickaudio.Play();
        }


        if (gameObject.tag == "Shovel")
        {
            Tool_Manager.currentTool = "Shovel";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().shovel();
            Clickaudio.Play();
        }


        if (gameObject.tag == "Scythe")
        {
            Tool_Manager.currentTool = "Scythe";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().scythe();
            Clickaudio.Play();
        }

        if (gameObject.tag == "Soil")
        {
            Tool_Manager.currentTool = "Soil";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().soil();
            Clickaudio.Play();
        }


        if (gameObject.tag == "Watering Can")
        {
            Tool_Manager.currentTool = "Watering Can";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().water();
            Clickaudio.Play();
        }


        if (gameObject.tag == "Grow")
        {
            Tool_Manager.currentTool = "Grow";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().grow();
            Clickaudio.Play();
        }

        if (gameObject.tag == "Hoe")
        {
            Tool_Manager.currentTool = "Hoe";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().hoe();
            Clickaudio.Play();
        }

        if (gameObject.tag == "Happy Seeds")
        {
            Tool_Manager.currentTool = "Happy Seeds";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().happy();
            Clickaudio.Play();
        }

        if (gameObject.tag == "Tulip Seeds")
        {
            Tool_Manager.currentTool = "Tulip Seeds";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().tulip();
            Clickaudio.Play();
        }

        if (gameObject.tag == "Sunflower Seeds")
        {
            Tool_Manager.currentTool = "Sunflower Seeds";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().sunflower();
            Clickaudio.Play();
        }

        if (gameObject.tag == "Rose Seeds")
        {
            Tool_Manager.currentTool = "Rose Seeds";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().rose();
            Clickaudio.Play();
        }

        if (gameObject.tag == "Heart Seeds")
        {
            Tool_Manager.currentTool = "Heart Seeds";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().heart();
            Clickaudio.Play();
        }

        if(gameObject.tag == "Cancel")
        {
            Tool_Manager.currentTool = "Cancel";
            Debug.Log(Tool_Manager.currentTool);
            Cursor_Mode.GetComponent<Cursor_Mode>().cancel();
            Clickaudio.Play();
        }


      

    }
}
