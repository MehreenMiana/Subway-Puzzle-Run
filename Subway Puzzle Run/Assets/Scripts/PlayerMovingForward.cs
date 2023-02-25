using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingForward : MonoBehaviour
{
    public TimerScript TimerReference;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NextPlatform")
        {
            int _currentPlatform = (int)Random.Range(1, 10) % GameManager.Instance.Platforms.Count;
            Instantiate(GameManager.Instance.Platforms[_currentPlatform],new Vector3 (GameManager.Instance.PointForInstantiate.transform.position.x-38f, 0,0), this.transform.rotation);
        }
        if (other.gameObject.tag == "SlowMo")
        {
            GameManager.Instance.SetSlowMo(true);
            TimerReference.TimerStart();
            /*AddSlowMo();*/
        }
    }
    private void Update()
    {
        if(TimerReference.IsTicking)
        {
            if (TimerReference.TimerInSeconds >=3f)
            {
                TimerReference.TimerStop();
                TimerReference.TimerReset();
                GameManager.Instance.SetSlowMo(false);
            }
        }
    }
    public void AddSlowMo()
    {
        TimerReference.TimerStart();
        GameManager.Instance.SetSlowMo(true);

        TimerReference.TimerStop();
        GameManager.Instance.SetSlowMo(false);

    }
/*    IEnumerator AddSlowMo()
    {
        GameManager.Instance.SetSlowMo(true);
        yield return new WaitForSeconds(3f);
        GameManager.Instance.SetSlowMo(false);
    }*/
}
