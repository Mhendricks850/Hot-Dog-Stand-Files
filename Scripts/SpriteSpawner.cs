using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpawner : MonoBehaviour {

	public GameObject Woman1;
	public int minWait = 1.0;
	public int maxWait = 10.0;


	// Use this for initialization
	 Start () {
		while(true)
		{
			yield return new WaitForSeconds(Random.Range(minWait, maxWait));
			Instantiate(Woman1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void spawn () {
		Instantiate (Woman1);
	}
}
