using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class CubeController : MonoBehaviour {

	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	public Text countText;
	public Text winText;
	EventListener listener;
	int direction;
	private int count;

	// Use this for initialization
	void Start () {
		listener = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<EventListener>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);		
		
		listener.handleEvent (transform.position, transform.rotation, direction);

		if (Input.GetKey("up")){
			direction = 1;
			listener.handleEvent (transform.position, transform.rotation, direction);
		}
		else if (Input.GetKey("down")){
			direction = 2;
			listener.handleEvent (transform.position, transform.rotation, direction);
		}
		else if (Input.GetKey("left")){
			direction = 3;
			listener.handleEvent (transform.position, transform.rotation, direction);
		}
		else if (Input.GetKey ("right")) {
			direction = 4;
			listener.handleEvent (transform.position, transform.rotation, direction);
		} else {
			listener.handleEvent (transform.position, transform.rotation, 0);
		}
   }

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("crystal"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Crystals picked: " + count.ToString ();
		if (count >= 2)
		{
			winText.text = "YOU WIN!";
		}
	}
		

}
