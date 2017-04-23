using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.ThirdPerson;


public class Respawn : MonoBehaviour {
	IDictionary<string, GameObject> clients;
	float TranslateSpeed = 10f;
	// Use this for initialization
	void Start () {
		clients = new Dictionary<string, GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void addClient(string id, Vector3 pos, Quaternion rot){
		GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
		gameObject.AddComponent<Rigidbody> ();
		gameObject.transform.position = pos;
		gameObject.transform.rotation = rot;
		clients.Add (id, gameObject);
	}

	public void moveClient(string id, Vector3 pos, Quaternion rot){
		GameObject gameObject = clients [id];
		gameObject.transform.position = pos;
		gameObject.transform.rotation = rot;
	}

	public void goforward(string id, Vector3 pos, Quaternion rot){
		GameObject gameObject = clients [id];
		gameObject.transform.position = pos;
		gameObject.transform.rotation = rot;
		//gameObject.transform.Translate (Vector3.forward * TranslateSpeed);
	}

	public void gobackward(string id, Vector3 pos, Quaternion rot){
		GameObject gameObject = clients [id];
		gameObject.transform.position = pos;
		gameObject.transform.rotation = rot;
		//gameObject.transform.Translate (Vector3.back * TranslateSpeed);
	}

	public void goleft(string id, Vector3 pos, Quaternion rot){
		GameObject gameObject = clients [id];
		gameObject.transform.position = pos;
		gameObject.transform.rotation = rot;
		//gameObject.transform.Translate (Vector3.left * TranslateSpeed);
	}

	public void goright(string id, Vector3 pos, Quaternion rot){
		GameObject gameObject = clients [id];
		gameObject.transform.position = pos;
		gameObject.transform.rotation = rot;
		//gameObject.transform.Translate (Vector3.right * TranslateSpeed);
	}

}
