using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Coin_Shop : MonoBehaviour
{
    public static int coin = 50;
    public TextMeshProUGUI coinsUI;

    void Start()
    {
        
    }

    
    void Update()
    {
        Debug.Log(coin);
        coinsUI.text = coin.ToString();

        if (coin <= 0)
        {
            coin = 0;
            Debug.Log("Off");
        }

        if(coin >= 500)
        {
            Debug.Log("You win!");
            SceneManager.LoadScene(2);
        }

     
    }

  


}
