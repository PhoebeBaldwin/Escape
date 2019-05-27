using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzleLaunch : MonoBehaviour
{

    public Text Message;
    // Use this for initialization
    void Start()
    {

    }


    void onTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Message.text = "Press space to start puzzle!";
        }
    }

}
