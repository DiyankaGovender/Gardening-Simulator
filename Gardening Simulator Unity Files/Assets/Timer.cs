using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float timeLeft = 300f;
    public TextMeshProUGUI timer;
    bool clock;
    private float mins;
    private float secs;

    public int coinAmount = 20;

    void Update()
    {
        if (timeLeft > 0 && clock == false)
        {
            clock = true;
            StartCoroutine(Wait());
        }

    }

    IEnumerator Wait()
    {
        timeLeft -= 1;
        UpdateTimer();
        yield return new WaitForSeconds(1);
        clock = false;
    }

    void UpdateTimer()
    {
        int min = Mathf.FloorToInt(timeLeft / 60);
        int sec = Mathf.FloorToInt(timeLeft % 60);
        
        timer.text = min.ToString("00") + ":" + sec.ToString("00");



        if (timeLeft > 0 && clock == false)
        {
            clock = true;
            StartCoroutine(Wait());
        }

        //LOSE GAME
        if (timeLeft <= 0)
        {
            SceneManager.LoadScene(3);
        }

        if (timeLeft == 270)
        {
            Coin_Shop.coin += coinAmount;
            Debug.Log("coin");
        }

        if (timeLeft == 240)
        {
            Coin_Shop.coin += coinAmount;
            Debug.Log("coin");
        }

        if (timeLeft == 210)
        {
            Coin_Shop.coin += coinAmount;
            Debug.Log("coin");
        }

        if (timeLeft == 180)
        {
            Coin_Shop.coin += coinAmount;
            Debug.Log("coin");
        }

        if (timeLeft == 150)
        {
            Coin_Shop.coin += coinAmount;
            Debug.Log("coin");
        }

        if (timeLeft == 120)
        {
            Coin_Shop.coin += coinAmount;
            Debug.Log("coin");
        }

        if (timeLeft == 270)
        {
            Coin_Shop.coin += coinAmount;
            Debug.Log("coin");
        }

        if (timeLeft == 90)
        {
            Coin_Shop.coin += coinAmount;
            Debug.Log("coin");
        }

        if (timeLeft == 60)
        {
            Coin_Shop.coin += coinAmount;
            Debug.Log("coin");
        }

        if (timeLeft == 30)
        {
            Coin_Shop.coin += coinAmount;
            Debug.Log("coin");
        }


    }
}