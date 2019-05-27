using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button2 : MonoBehaviour
{
    public InputField answer;
    public Text fText;
    public static bool completedLevel2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

            SceneManager.LoadScene("opening");
    }
    public void getInput()
    {
        Debug.Log(answer.text);
        if (answer.text == "B")
        {
            Debug.Log("Correct");
            fText.text = "Correct!! Search the room for the next puzzle!";
            if (completedLevel2 == false)
            {
                ScoreScript.scoreValue += 1;
                completedLevel2 = true;
            }
            else
            {
                Debug.Log("Completed");
            }


        }


        if (answer.text != "B")
            fText.text = "Inorrect!!";

    }
}