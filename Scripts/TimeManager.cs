using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeManager : MonoBehaviour {

	public Text timetext;
	private float Daytime;

	void Update () {
		Daytime = Time.time;
		timetext.text = Daytime.ToString ("0:00");
	}
}
