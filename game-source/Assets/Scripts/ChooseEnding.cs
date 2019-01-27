using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseEnding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameManager.KarmaPoints <= -4)
            {
                SceneManager.LoadScene("Ending1");
            }
            else if (gameManager.KarmaPoints <= 0)
            {
                SceneManager.LoadScene("Ending2");
            }
            else if (gameManager.KarmaPoints <= 3)
            {
                SceneManager.LoadScene("Ending3");
            }
            else 
            {
                SceneManager.LoadScene("Ending4");
            }
        }
    }
}
