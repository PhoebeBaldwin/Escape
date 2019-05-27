using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoorCode : MonoBehaviour {
    Text code;
    public int score;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
        score = ScoreScript.scoreValue;
        if(score >= 3)
        {
            
        }
	}
}
