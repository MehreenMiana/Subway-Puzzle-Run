//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class PuzzleController : MonoBehaviour
//{
  
//    public static PuzzleController instance;
//    public bool platform_bool;

//    public GameObject[] platforms;

//    public int puzzles_Placed = 0;

//    private void Awake()
//    {
//        if (instance == null)
//        {
//            instance = this;
//        }
//    }
  

//    void Start()
//    {
       


//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if(platform_bool == true)
//        {
//            disablePlatformScript();
//        }
//    }
//    public void PuzzleSolved()
//    {
//        if (PuzzleController.instance.puzzles_Placed >= 9)
//        {
//            enablePlatformScript();
//        }
     

//    }
//   public void DisplayPuzzle()
//   {
//        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovingForward>().enabled = false;
//        platform_bool = true;
//        disablePlatformScript();
//        GameObject.FindGameObjectWithTag("Player").gameObject.transform.GetChild(1).GetComponent<Animator>().Play("Idle");

//        GameManager.Instance.QuizPanel.SetActive(true);
//        timmer.TimerOn = true;
//        print("quiz");


//   }

//    public void disablePlatformScript()
//    {
//       platforms =  GameObject.FindGameObjectsWithTag("Platform");
//        int i = 0;
//        while(i > platforms.Length)
//        {
//            platforms[i].GetComponent<MovingSurface>().enabled = false;
//            i++;
//        }

//    }
//    public void enablePlatformScript()
//    {
//        platforms = GameObject.FindGameObjectsWithTag("Platform");
//        int i = 0;
//        while (i > platforms.Length)
//        {
//            platforms[i].GetComponent<MovingSurface>().enabled = true;
//            i++;
//        }
//        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovingForward>().enabled = true;
//        platform_bool = true;
//        disablePlatformScript();
//        GameObject.FindGameObjectWithTag("Player").gameObject.transform.GetChild(1).GetComponent<Animator>().Play("Run");

//        GameManager.Instance.QuizPanel.SetActive(false);
//        timmer.TimerOn = false;

//    }

//}

