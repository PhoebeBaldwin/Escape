using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : MonoBehaviour {

    void onTriggerEnter2D(Collider2D other)
    {

        Debug.Log("Object Entered the trigger");
    }

}
