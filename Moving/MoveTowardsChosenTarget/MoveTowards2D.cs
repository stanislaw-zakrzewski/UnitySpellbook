using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards2D : MonoBehaviour {
    private Vector2 target;
    private float maxDistanceDelta;

	void Start () {
        //Remember to set appropriate values to target and maxDistanceDelta
        target = new Vector2();
        maxDistanceDelta = 0;
	}
	
	void Update () {
        //This line must be in update
        //Moves Game Object attached to script towards target point in steps of maxDistanceDelta length, or less if it is closer than maxDistanceDelta
        transform.position = Vector2.MoveTowards(transform.position, target, maxDistanceDelta);
	}

    public Vector2 Target { get { return target; } set { target = value; } }
    public float MaxDistanceDelta { get { return maxDistanceDelta; } set { maxDistanceDelta = value; } }
}
