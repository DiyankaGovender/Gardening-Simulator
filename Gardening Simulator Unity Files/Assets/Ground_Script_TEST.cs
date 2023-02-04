using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Script_TEST : MonoBehaviour
{
    public Sprite grass;
    public Sprite dirt;
    public Sprite empty;
    public Sprite soil;
    public Sprite waterSoil;

    public bool isDirtcanSoil;
    public bool isSoilcanWater;

    void Start()
    {
        isDirtcanSoil = false;
        isSoilcanWater = false;
}

   
    void Update()
    {
        Physics.IgnoreLayerCollision(1, 20);
    }

    public void OnMouseDown()
    {
        //GRASS TO DIRT
        if(Tool_Manager.currentTool =="Shovel"  && (GetComponent<SpriteRenderer>().sprite = grass))
        {
            GetComponent<SpriteRenderer>().sprite = dirt;
            isDirtcanSoil = true;
        }

        //DIRT TO SOIL
        if (Tool_Manager.currentTool == "Soil" && (GetComponent<SpriteRenderer>().sprite = dirt) &&
            isDirtcanSoil==true)
        {
            Debug.Log("cLICK");
            GetComponent<SpriteRenderer>().sprite = soil;
            isSoilcanWater = true;
        }

        //SOIL TO WATER
        if (Tool_Manager.currentTool == "Watering Can" && (GetComponent<SpriteRenderer>().sprite = dirt) &&
            isSoilcanWater == true)
        {
            Debug.Log("cLICK");
            GetComponent<SpriteRenderer>().sprite = waterSoil;
        }
    }
}
