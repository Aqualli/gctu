using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool GameIsOver;

    public GameObject gameOverUI;

    public GameObject completeLevelUI;
   

    void Start ()
    {
        GameIsOver = false;
    }


        
    void Update() {

        if(PlayerStats.Lives == 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {

        
        gameOverUI.SetActive(true);

    }

    public void WinLevel()
    {
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }


}
