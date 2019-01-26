using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

/**
 * Shows the current accumulated time
 */
public class TimerText : MonoBehaviour
{
    [Inject]
    private Timer _timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = _timer.GetTime().ToString();
    }
}
