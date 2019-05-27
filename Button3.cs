using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button3 : MonoBehaviour
{
    public InputField answer;
    public Text fText;
    public static bool completedLevel3;
    public int EntryScore;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

            SceneManager.LoadScene("opening");
    }
    public void getInput()
    {
        EntryScore = ScoreScript.scoreValue;
        Debug.Log(completedLevel3);
        if (answer.text == "E") {
            Debug.Log("Correct");
            fText.text = "Correct!! Search the room for the next puzzle!";
            if(completedLevel3 == false)
            {
                ScoreScript.scoreValue += 1;
                completedLevel3 = true;
            }
            else
            {
                Debug.Log("Completed");
            }

          
        }
    

       


        

        if (answer.text != "E"  )
            fText.text = "Inorrect!!";

    }
}