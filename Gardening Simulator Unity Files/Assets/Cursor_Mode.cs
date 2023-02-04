using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor_Mode : MonoBehaviour
{
   // public Texture2D axeImage;
    public Texture2D shovelImage;
    public Texture2D scytheImage;
    public Texture2D soilImage;
    public Texture2D waterImage;
    public Texture2D growthImage;
    public Texture2D hoeImage;
    public Texture2D axeImage;
    public Texture2D happyImage;
    public Texture2D tulipImage;
    public Texture2D sunflowerImage;
    public Texture2D roseImage;
    public Texture2D heartImage;
    public Texture2D cancelImage;
  

    void Start()
    {
       
    }

   
    void Update()
    {
        
    }

    public void axe()
    {
      Cursor.SetCursor(axeImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void shovel()
    {
        Cursor.SetCursor(shovelImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void scythe()
    {
       Cursor.SetCursor(scytheImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void soil()
    {
      Cursor.SetCursor(soilImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void water()
    {
        Cursor.SetCursor(waterImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void grow()
    {
        Cursor.SetCursor(growthImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void hoe()
    {
        Cursor.SetCursor(hoeImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void happy()
    {
        Cursor.SetCursor(happyImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void tulip()
    {
        Cursor.SetCursor(tulipImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void sunflower()
    {
        Cursor.SetCursor(sunflowerImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void rose()
    {
        Cursor.SetCursor(roseImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void heart()
    {
         Cursor.SetCursor(heartImage, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void cancel()
    {
        Cursor.SetCursor(cancelImage, Vector2.zero, CursorMode.ForceSoftware);
    }

   
}
