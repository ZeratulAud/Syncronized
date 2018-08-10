using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {
    [SerializeField] public GameObject start;
    [SerializeField] public GameObject end;
    [SerializeField] public bool activated = false;
    [SerializeField] public bool continuous = false;
    [SerializeField] private bool goingTowardsEnd = true;
    [SerializeField] public float speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!activated)
            return;

        Vector3 targetPos;

        if (goingTowardsEnd)
        {
            targetPos = end.transform.position;
        }
        else
        {
            targetPos = start.transform.position;
        }

        if (transform.position == targetPos)
        {
            if (continuous)
            {
                if (goingTowardsEnd)
                {
                    goingTowardsEnd = false;
                    targetPos = start.transform.position;
                }
                else
                {
                    goingTowardsEnd = true;
                    targetPos = end.transform.position;
                }
            }
            else
            {
                activated = false;
            }
        }
        float step = speed * Time.deltaTime;

        // Move our position a step closer to the target.
        transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
    }
}
