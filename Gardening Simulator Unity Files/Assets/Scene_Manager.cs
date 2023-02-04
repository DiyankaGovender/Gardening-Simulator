using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void inGame()
    {
        SceneManager.LoadScene(1);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void win()
    {
        SceneManager.LoadScene(2);
    }

    public void lose()
    {
        SceneManager.LoadScene(3);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void howtoplay()
    {
        SceneManager.LoadScene(4);
    }

    public void references()
    {
        SceneManager.LoadScene(5);
    }
}
