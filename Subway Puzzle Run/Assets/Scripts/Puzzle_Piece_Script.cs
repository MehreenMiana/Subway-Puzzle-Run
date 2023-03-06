using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Puzzle_Piece_Script : MonoBehaviour
    {

        float[] rotations = { 0, 90, 180, 270 };

        public float correctRotation ;
        [SerializeField]
        bool isPlaced = false;

        int PossibleRots = 1;
        public float myRotation;

        PuzzleController gameManager;

        private void Awake()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<PuzzleController>();
        }

    private void Update()
    {

        if (Input.GetMouseButton(0))
        {
            print("button pressed");
            MouseDown();
        }
       
    }
    private void Start()
        {
            PossibleRots = 1;
            int rand = Random.Range(0, rotations.Length);
            transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
            myRotation = rotations[rand];
      
            if (myRotation == correctRotation)
            {
                    isPlaced = true;
                    gameManager.correctMove(isPlaced);
                 print(" angle-------" + transform.eulerAngles.z);
            }
            
            else
            {
                if (myRotation == correctRotation)
                {
                    isPlaced = true;
                    gameManager.correctMove(isPlaced);
                  
                }
            }
        }

        public void MouseDown()
        {
        print("mouse down");
            transform.Rotate(new Vector3(0, 0, 0));
            rotaionChange();
       
                if (myRotation == correctRotation && isPlaced == false)
                {
                    isPlaced = true;
                    gameManager.correctMove(isPlaced);
                  
                }
                else if (isPlaced == true)
                {
                    isPlaced = false;
                    gameManager.wrongMove(isPlaced);
               
                   
                }
            
            else
            {
                if (myRotation == correctRotation && isPlaced == false)
                {
                    isPlaced = true;
                    gameManager.correctMove(isPlaced);
                   
                }
                else if (isPlaced == true)
                {
                    isPlaced = false;
                    gameManager.wrongMove(isPlaced);
                
                }
            }
        }

        void rotaionChange()
        {
            if(myRotation >= 270)
            {
                myRotation = 0;
            }
            else if(myRotation < 0){
                myRotation = 0;
            }
            else
            {
                myRotation = myRotation + 90;
            }
        }
    }
