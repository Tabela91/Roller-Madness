using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	public float speed = 70.0f;//change made here
	
	public enum whichWayToRotate {AroundX, AroundY, AroundZ}

    //variable renamed here
	public whichWayToRotate direction = whichWayToRotate.AroundX;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //variable renamed here
		switch(direction)
		{
		case whichWayToRotate.AroundX:
			transform.Rotate(Vector3.right * Time.deltaTime * speed*5);
			break;
		case whichWayToRotate.AroundY:
			transform.Rotate(Vector3.up * Time.deltaTime * speed * 5);
			break;
		case whichWayToRotate.AroundZ:
			transform.Rotate(Vector3.forward * Time.deltaTime * speed * 5);
			break;
		}	
	}
}