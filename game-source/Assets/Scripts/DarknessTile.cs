using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DarknessTile : MonoBehaviour
{
    [Inject]
    private Timer _timer;
    public Animator animator;
    private float DarkeningSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Object.DontDestroyOnLoad(this);
        //animator = gameObject.GetComponent<Animator>();
        //animator.SetBool("DarknessFalls", false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        animator.speed = DarkeningSpeed;
        //_timer.Update(this);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DarkeningSpeed = .005f;
            StartDark();
        }
        
        //
    }

    public void SpeedUpDark()
    {
        Debug.Log("Hey");
        DarkeningSpeed = 1f;
    }
    public void DarknessWins()
    {
        DarkeningSpeed = 1f;
        animator.SetBool("DarknessFalls", true);
        Debug.Log("I bet you didn't see that comming!");
    }

    public void StartDark()
    {
        animator.SetBool("DarknessFalls", true);
    }


}
