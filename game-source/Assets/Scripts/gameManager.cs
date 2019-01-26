using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    //Set the starting point for the karma system
    public static int KarmaPoints = 0;

    private void Start()
    {
        //If the current level in the main menu, reset the karma points.
        DontDestroyOnLoad(this.gameObject);
        Scene CurrentScene = SceneManager.GetActiveScene();
        if(CurrentScene.name == "Main Menu")
        {
            KarmaPoints = 0;
        }
    }

    //Load the first level
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    //Quit Game
    public void ExitGame()
    {
        Application.Quit();
    }
}
