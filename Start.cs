using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour {

	// Use this for initialization
	public void StartButton () {
        SceneManager.LoadScene("opening");

    }

    public void instructionButton()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void menuButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void storyButton()
    {
        SceneManager.LoadScene("Story");
    }

    public void Leave()
    {
        Application.Quit();
    }

}
