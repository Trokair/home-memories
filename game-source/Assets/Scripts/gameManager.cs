using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static int KarmaPoints = 0;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        Scene CurrentScene = SceneManager.GetActiveScene();
        if(CurrentScene.name == "Main Menu")
        {
            KarmaPoints = 0;
        }
    }
}
