using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string Level;
    public int CurrentKarma;
    private bool onTrigger = false;

    // Start is called before the first frame update
    //voidStart()
    //{

    //}

    private void OnTriggerStay2D(Collider2D collision)
    {
        onTrigger = true;
        //Door cracks open when the player approaches it
        //  crack door
        //  play Door Crack audio

       
    }

    void Update()
    {
        //If the player presses the "e" key it loads the next level
        if (onTrigger && Input.GetKeyDown("e"))
        {
            
            //Load the scene set for this door
            SceneManager.LoadScene(Level);

            //Update the karma points in the gameManager
            CurrentKarma = gameManager.KarmaPoints;
            CurrentKarma = CurrentKarma + 5;
            gameManager.KarmaPoints = CurrentKarma;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //close door
        //   play audio
        onTrigger = false;
    }

}