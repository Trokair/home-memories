using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog
{
    //Makes the editor textbox space bigger
    [TextArea(3,10)]

    //An array for the sentences that get later placed in a queue.
    public string[] sentences;
}
