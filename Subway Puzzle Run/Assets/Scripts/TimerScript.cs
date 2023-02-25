using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float TimerInSeconds=0f;
    public bool IsTicking = false;

    private void Update()
    {
        if (IsTicking)
        {
            TimerInSeconds += Time.deltaTime;
        }
        
    }
    public void TimerReset()
    {
        IsTicking = false;
        TimerInSeconds = 0f;
    }
    public void TimerStart()
    {
        IsTicking = true ;
    }
    public void TimerStop()
    {
        IsTicking = false;
    }
}
