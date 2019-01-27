using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class DialogManager : MonoBehaviour
{
    [Inject]
    private Controls _Controls;
    public GameObject Character;
    public Text dialogText;
    public bool FirstTimeDialog = true;
    public static string ReadyForTrigger = "false";
    public Animator animator;

    private Queue<string> sentences;

    void Start()
    {
        animator.SetBool("IsOpen", false);
        
        //Create a list for all the pre-made sentences.
        sentences = new Queue<string>();

    //Ready the Dialog Trigger to display dialog.
    ReadyForTrigger = "true";
        
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
    }

    void Update()
    {
        //If the dialog box is open, pressing the E key will display the next sentence.
        if (animator.GetBool("IsOpen") == true)
        {
            if(FirstTimeDialog == true)
            {
                DisplayNextSentence();
                FirstTimeDialog = false;
            }
            Character.gameObject.GetComponent<Animator>().enabled = false;
            Character.gameObject.GetComponent<Player>().enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                DisplayNextSentence();
                Debug.Log("Display'ed next sentence");
            }
        }
    }


    public void StartDialog(Dialog dialog)
    {
        _Controls.LockControls();
        ReadyForTrigger = "false";
        //Opens the dialog box
        animator.SetBool("IsOpen",true);
        Character.gameObject.GetComponent<Animator>().enabled = false;
        //Clears the current queue
        sentences.Clear();

        //This loads each sentence into the queue.
        foreach (string sentence in dialog.sentences)
        {
            Debug.Log("Display'ed next sentence");
            sentences.Enqueue(sentence);

        }
    }

   
    public void DisplayNextSentence ()
    {
        //This runs when there is no more sentences to display.
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }

        //This takes the next sentence out of the queue and prepares it for use
        string sentence = sentences.Dequeue();
        dialogText.text = sentence;
        Debug.Log(sentence);
    }

    void EndDialog()
    {
        //This closes the dialog box
        animator.SetBool("IsOpen", false);
        Character.gameObject.GetComponent<Animator>().enabled = true;
        _Controls.UnlockControls();
        Debug.Log("End");
    }
}
