using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class EventGenerator : MonoBehaviour {
	EventListener listener;
	int direction;

	// Use this for initialization
	void Start () {
		listener = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<EventListener>();
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.anyKey) {
			listener.handleEvent(transform.position, transform.rotation);
		}*/
		if (Input.GetKey("up")){
			direction = 1;
			listener.handleEvent (transform.position, transform.rotation, direction);
		}
		if (Input.GetKey("down")){
			direction = 2;
			listener.handleEvent (transform.position, transform.rotation, direction);
		}
		if (Input.GetKey("left")){
			direction = 3;
			listener.handleEvent (transform.position, transform.rotation, direction);
		}
		if (Input.GetKey("right")){
			direction = 4;
			listener.handleEvent (transform.position, transform.rotation, direction);
		}
	}
}
