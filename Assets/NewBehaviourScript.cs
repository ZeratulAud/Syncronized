using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour {
    public static int activated;
    [SerializeField] public GameObject crate;
    // Use this for initialization
    //public static bool gravityDirection = true;
    private void OnTriggerEnter2D(Collider2D other)
    {
       

        Debug.Log("Gravity activated");
        activated = 1;
        
        /*if(gravityDirection)
        {
            //gravityDirection = false;
        }
        */
        

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Gravity de-activated");
        activated = 0;
    }

 }
