using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DoorUnlock : MonoBehaviour {

    public InputField dCode;
    public Text fText;
    public string LevelToLoad;
    // Use this for initialization
    void Start () {
		
	}
	

    public void unlock()
    {
        if (dCode.text == "4296")
        {
            fText.text = "Congrats!! you are now ready for the test!";
            LevelToLoad = "Menu";
        }
        else
        {
            fText.text = "You need to complete all 3 puzzles to get the code!";
            LevelToLoad = "opening";
        }
    }
    public void complete()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
