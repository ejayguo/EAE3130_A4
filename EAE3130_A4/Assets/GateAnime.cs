using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateAnime : MonoBehaviour {


	float timerWaiting = 0.0f;
	float posYDelta = 0.1f;
	// Use this for initialization
	void Start () 
	{
		timerWaiting = Random.Range (0.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (timerWaiting < 2.0f) 
		{
			timerWaiting += Time.deltaTime;
		}
		else
		{
			if (posYDelta > 0.0f && this.transform.position.y > 4.31f) 
			{
				timerWaiting = 0.0f;
				posYDelta = -0.1f;
			} else if (posYDelta < 0.0f && this.transform.position.y < 1.61f) 
			{
				timerWaiting = 0.0f;
				posYDelta = 0.1f;
			} else 
			{
				Vector3 posOld = this.transform.localPosition;
				this.transform.localPosition = new Vector3 (posOld.x, posOld.y+posYDelta, posOld.z);
			}
		}
	}
}
