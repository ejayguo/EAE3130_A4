using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeController : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void ContactPlayer()
	{
		this.transform.parent.gameObject.SendMessage ("DestroyCake");
	}

}
