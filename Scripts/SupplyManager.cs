using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class SupplyManager : MonoBehaviour {

	private int Hotdogs, Buns, Trays, Condiments, Cash;
	public Text HotDogcount, Buncount, Traycount, Condimentcount, Cashcount;

	// Use this for initialization
	void Start () {
		Hotdogs = 0;
		Buns = 0;
		Trays = 0;
		Condiments = 0;
		Cash = 250;

	}

	public void Reset () {
		PlayerPrefs.SetInt("Hotdogs", 0);
		PlayerPrefs.SetInt("Buns", 0);
		PlayerPrefs.SetInt("Trays", 0);
		PlayerPrefs.SetInt("Condiments", 0);
		PlayerPrefs.SetInt ("Cash", 250);
	}
	
	// Update is called once per frame
	void Update () {
		HotDogcount.text = "Hotdogs: " + PlayerPrefs.GetInt("Hotdogs");
		Buncount.text = "Buns: " + PlayerPrefs.GetInt("Buns");
		Traycount.text = "Trays: " + PlayerPrefs.GetInt("Trays");
		Condimentcount.text = "Condiments: " + PlayerPrefs.GetInt("Condiments");
		Cashcount.text = "Cash: " + PlayerPrefs.GetInt ("Cash");
	}
		
	public void AddHotdogs () {
		Hotdogs += 12;
		Cash -= 5;  
		PlayerPrefs.SetInt("Hotdogs", Hotdogs);
		PlayerPrefs.SetInt ("Cash", Cash);
		print ("Hotdogs");
	}

	public void AddBuns () {
		Buns += 12;
		Cash -= 3;
		PlayerPrefs.SetInt("Buns", Buns);
		PlayerPrefs.SetInt ("Cash", Cash);
		print ("Buns");
	}

	public void AddTrays () {
		Trays += 20;
		Cash -= 1;
		PlayerPrefs.SetInt("Trays", Trays);
		PlayerPrefs.SetInt ("Cash", Cash);
		print ("Trays");
	}

	public void AddCondiments () {
		Condiments += 3;
		Cash -= 1;
		PlayerPrefs.SetInt("Condiments", Condiments);
		PlayerPrefs.SetInt ("Cash", Cash);
		print ("Condiments");
	}
}
