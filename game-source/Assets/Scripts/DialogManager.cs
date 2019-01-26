using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    
    public Text dialogText;
    public static string ReadyForTrigger = "false";
    public Animator animator;

    private Queue<string> sentences;

    void Start()
    {

    //Create a list for all the pre-made sentences.
    sentences = new Queue<string>();

    //Ready the Dialog Trigger to display dialog.
    ReadyForTrigger = "true";
        
    }

    void Update()
    {
        //If the dialog box is open, pressing the E key will display the next sentence.
        if (animator.GetBool("IsOpen")== true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DisplayNextSentence();
            }
        }
    }


    public void StartDialog(Dialog dialog)
    {
        ReadyForTrigger = "false";
        //Opens the dialog box
        animator.SetBool("IsOpen",true);
        //Clears the current queue
        sentences.Clear();

        //This loads each sentence into the queue.
        foreach (string sentence in dialog.sentences)
        {
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
    }

    void EndDialog()
    {
        //This closes the dialog box
        animator.SetBool("IsOpen", false);
    }
}
