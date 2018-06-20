using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour 
{
	public bool hasPlayerleft = true;
	public GameObject gate;
	public GameObject trigger01;
	public GameObject trigger02;
	public GameObject trigger03;
	public GameObject trigger04;
	public GameObject obj;
	public GameObject cakePrefab;
	public GameObject enemyPrefab;

	// Use this for initialization
	void Start () 
	{
		int randPos = Random.Range (-1, 1);

		if (randPos == 0) 
		{
			randPos = randPos + 1;
		}

		float posNew = randPos * 4.48f;


		int randZX = Random.Range (0, 2) * 90;

		gate.transform.Rotate (Vector3.up, randZX);

//		Debug.Log (randZX);
//		Debug.Log (randPos);

		if (randZX == 90) 
		{
			gate.transform.localPosition = new Vector3 (posNew, 1.61f, 0);
		} 
		else 
		{
			gate.transform.localPosition = new Vector3 (0, 1.61f, posNew);
		}
	}

	// Update is called once per frame
	void Update () 
	{

	}

	void DestroyCake()
	{
		Destroy (obj);
		obj = null;
	}

	void DetectPlayer()
	{

		if (hasPlayerleft == true) 
		{
			int rand = Random.Range (0, 2);

			if (rand == 0) 
			{
				obj = Instantiate (cakePrefab, transform.position, transform.rotation);
				obj.transform.parent = this.transform;
			} 
			else 
			{
				obj = Instantiate (enemyPrefab, transform.position, transform.rotation);
				GameObject objPlayer = GameObject.Find ("player");
				obj.SendMessage ("SetTarget", objPlayer.transform);
			}

			hasPlayerleft = false;
		} 
		else 
		{
			if (obj != null && obj.tag == "TAG_CAKE") 
			{
				Destroy (obj);
				obj = null;

			} 
			hasPlayerleft = true;
		}

	}

}
