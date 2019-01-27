using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    [Inject]
    Controls _controls;
  
    // Start is called before the first frame update
    void Start()
    {
        Object.DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _controls.HandleMovement(this.transform);
    }
}
