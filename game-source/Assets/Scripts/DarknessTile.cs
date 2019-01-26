﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DarknessTile : MonoBehaviour
{
    [Inject]
    private Timer _timer;
    // Start is called before the first frame update
    void Start()
    {
        Object.DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        _timer.Update(this);
    }
}
