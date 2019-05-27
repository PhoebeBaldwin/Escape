using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour {

    public string levelToLoad; 

    public void note()
    {
        Debug.Log("note");
        Application.LoadLevel(levelToLoad);
    }
	

    void OnTriggerEnter2D(Collider2D co)
    {
        if(co.name == "Player")
        {
            Debug.Log("Note");
            Application.LoadLevel(levelToLoad);
        }
    }
}
