using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {
    public InputField answer;
    public Text fText;
    public static bool completedLevel1;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

            SceneManager.LoadScene("opening");
    }
    public void  getInput()
    {
        if (answer.text == "A")
        {
            Debug.Log("Correct");
            fText.text = "Correct!! Search the room for the next puzzle!";
            if (completedLevel1 == false)
            {
                ScoreScript.scoreValue += 1;
                completedLevel1 = true;
            }
            else
            {
                Debug.Log("Completed");
            }


        }


        if (answer.text != "A")
             fText.text = "Inorrect!!";

    }
}
