using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter(Collision collision)
	{
//		Debug.Log ("Collision:" + collision.gameObject.tag);
//		collision.gameObject.SendMessage ("ContactPlayer");
	}

	void OnTriggerEnter(Collider collider)
	{
//		Debug.Log ("Trigger: " + collider.gameObject.tag);
		collider.gameObject.SendMessage ("ContactPlayer");
	}
}
