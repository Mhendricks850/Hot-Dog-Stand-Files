using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weather : MonoBehaviour {

	public int[] CurrentWeather;
	public Text WeatherBox;

	// Use this for initialization
	void Start () {
		SetWeather (Random.Range (1, 5));
	}
	
//	 Update is called once per frame
	void Update () {

	}

	public void SetWeather (int CurrentWeather) {
		
		if (CurrentWeather == 1) {
			WeatherBox.text = "Weather: Sunny";
		}
		if (CurrentWeather == 2) {
			WeatherBox.text = "Weather: Raining";
		}
		if (CurrentWeather == 3) {
			WeatherBox.text = "Weather: Hot";
		}
		if (CurrentWeather == 4) {
			WeatherBox.text = "Weather: Cool";
		}
			
	}

}
