using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Timer that is used to determine when a player fades
 */
public class Timer
{
    private float time = 0;
    private float threshold = 0;
    private bool incrementTimer = true;

    public Timer(float timeThreshold)
    {
        threshold = timeThreshold;
    }
    
    public void Update(DarknessTile player)
    {
        if (incrementTimer)
        time += Time.deltaTime;
    }
    
    public float GetTime()
    {
        return time;
    }

    public void LockTimer()
    {
        incrementTimer = false;
    }

    public void UnlockTimer()
    {
        incrementTimer = true;
    }
}
