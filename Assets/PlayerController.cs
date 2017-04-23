using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float moveSpeed = 5.0f; 

	//private Rigidbody rb;

	void Start () {     
		//float colRadius = gameObject.GetComponent<SphereCollider>().radius;
		//rb = GetComponent<Rigidbody>();
	} 
	void Update() {

		Ray ray = new Ray (transform.position,-transform.up);

		RaycastHit hit;



		if(Physics.Raycast(ray,out hit,10)) {

			transform.position =  new Vector3(transform.position.x , hit.point.y + gameObject.GetComponent<SphereCollider>().radius, transform.position.z) ;

			transform.rotation = Quaternion.FromToRotation(Vector3.up,hit.normal);

		}  
		transform.Translate(transform.forward * moveSpeed * Time.deltaTime);
		//transform.Translate(transform.forward * moveSpeed * Time.deltaTime);

		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");

		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		//rb.AddForce (movement);
	}
}
