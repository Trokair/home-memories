using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool GameIsPaused = false;
    //Set the starting point for the karma system
    public static int KarmaPoints = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

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

    //This pauses or resumes the game
    public void PauseGame()
    {
        if(GameIsPaused == true)
        {
            PauseMenu.SetActive(false);
            //Give control back to the player

            //Unpause the game
            Time.timeScale = 1;

            GameIsPaused = false;
        }
        else
        {
            //pause the game
            Time.timeScale = 0;
            //remove control from player

            PauseMenu.SetActive(true);
            GameIsPaused = true;
        }
    }

    //Quit Game
    public void ExitGame()
    {
        Application.Quit();
    }
}
