using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour {

    [SerializeField] int gravityDirection;
    private ConstantForce2D crateForce;
    // Use this for initialization
   void Start()
    {
        // Physics2D.gravity *= -1;
        gravityDirection = 0;
        
    }



    // Update is called once per frame
    void Update () {
        gravityDirection = NewBehaviourScript.activated;
        crateForce = GetComponent<ConstantForce2D>();
        switch (gravityDirection)
        {
            case 0:
                crateForce.force = new Vector2(0, -20);
                break;

            case 1:
                crateForce.force = new Vector2(0, 20);
                break;

            case 2:
                crateForce.force = new Vector2(0, 0);
                break;

            case 3:
                crateForce.force = new Vector2(6, 0);
                break;
            case 4:
                crateForce.force = new Vector2(-6, 0);
                break;
            default:
                break;

        }
        
        
	}
}
