using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class PuzzleController : MonoBehaviour
    {
        [Header("GameObject References")]
        public GameObject PuzzleHolder;
        public GameObject[] Puzzles;
        public GameObject[] PuzzlesArr;
       
      



    public static PuzzleController instance;
    public bool platform_bool;

    public GameObject[] platforms;

    public int puzzles_Placed = 0;


    [SerializeField]int totalPipes = 0;
    [SerializeField]  int correctedPuzzle = 0;

 //   public GameObject WinText;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
        {
          
          //  WinText.SetActive(false);
            totalPipes = PuzzleHolder.transform.childCount;

            Puzzles = new GameObject[totalPipes];

            for (int i = 0; i < Puzzles.Length; i++)
            {
                Puzzles[i] = PuzzleHolder.transform.GetChild(i).gameObject;
            }
        }

        public void correctMove(bool value)
        {
            if(value == true)
            {
            correctedPuzzle = correctedPuzzle + 1;
               
            }
          

       //     Debug.Log("correct Move");

            if (correctedPuzzle == totalPipes)
            {
                Debug.Log("Solved!");
                enablePlatformScript();
          
                
            }
        }

        public void wrongMove(bool value)
        {
         if(value == false)
            {
                correctedPuzzle = correctedPuzzle - 1;
            }   
           
        }







    // Update is called once per frame
    void Update()
    {
        if (platform_bool == true)
        {
            disablePlatformScript();
        }
    }
    public void PuzzleSolved()
    {
        if (PuzzleController.instance.puzzles_Placed >= 9)
        {
            
        }


    }
    public void DisplayPuzzle()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovingForward>().enabled = false;
        platform_bool = true;
        disablePlatformScript();
        GameObject.FindGameObjectWithTag("Player").gameObject.transform.GetChild(0).GetComponent<Animator>().Play("Idle");

        GameManager.Instance.QuizPanel.SetActive(true);
        timmer.TimerOn = true;
        print("quiz");


    }

    public void disablePlatformScript()
    {
        platforms = GameObject.FindGameObjectsWithTag("Platform");
        int i = 0;
        while (i > platforms.Length)
        {
            platforms[i].GetComponent<MovingSurface>().enabled = false;
            i++;
        }

    }
    public void enablePlatformScript()
    {
        platforms = GameObject.FindGameObjectsWithTag("Platform");
        int i = 0;
        while (i > platforms.Length)
        {
            platforms[i].GetComponent<MovingSurface>().enabled = true;
            i++;
        }
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovingForward>().enabled = true;
        platform_bool = true;
        disablePlatformScript();
        GameObject.FindGameObjectWithTag("Player").gameObject.transform.GetChild(1).GetComponent<Animator>().Play("Run");

        GameManager.Instance.QuizPanel.SetActive(false);
        timmer.TimerOn = false;

    }

}
