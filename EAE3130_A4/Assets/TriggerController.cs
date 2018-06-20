using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour 
{
	public GameObject block;

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
//		if (other.gameObject.tag == "TAG_PLAYER") 
//		{
//		Debug.Log("[Trigger]ContactPlayer");
		block.SendMessage ("DetectPlayer");
//		}
	}
}
