using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    [Inject]
    Controls _controls;
    [Inject]
    Timer _timer;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _controls.HandleMovement(this.transform);
        _timer.Update(this);
    }
}
