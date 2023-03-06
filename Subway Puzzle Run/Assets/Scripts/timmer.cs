using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timmer : MonoBehaviour
{
    [SerializeField] float TimeLeft = 5;
    public static bool TimerOn = false;

    public Text TimerText;

    public static timmer instance;

    void Start()
    {
        instance = this;
      
    }

    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Time is UP!"); // gameOver
                GameManager.Instance.GameOverPanel.SetActive(true);
                GameObject.FindGameObjectWithTag("Player").gameObject.transform.GetChild(0).GetComponent<Animator>().Play("Death");
                TimeLeft = 0;
                TimerOn = false;
            }
        }
    }
    

    void updateTimer(float currentTime) { 
        currentTime += 1;

      
        float seconds = Mathf.FloorToInt(currentTime % 60);
        
        TimerText.text = seconds.ToString();
    }

}