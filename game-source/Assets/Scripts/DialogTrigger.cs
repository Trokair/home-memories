using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;
    public DialogManager DialogToManage;
    private void Start()
    {
      
    }
    public void Update()
    {
        //This is what starts the dialog box. Replace this with your prefered trigger
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        if(DialogToManage == null)
        {
            FindObjectOfType<DialogManager>().ReadyForDialog();
            DialogToManage = FindObjectOfType<DialogManager>();
        }
            if (DialogManager.ReadyForTrigger == "true" && DialogToManage != null)
            {

            //    Debug.Log("E");
                TriggerDialog();
            }
       // }
    }

    public void TriggerDialog()
    {
        //This tells the Dialog Manager to run the dialog.
        
        FindObjectOfType<DialogManager>().StartDialog(dialog);

    }
    

}
