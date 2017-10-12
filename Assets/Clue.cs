using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour {

	private bool pickedUp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PickUp() {
		if (pickedUp) {
			Inventory.instance.SelectObject(this.gameObject);
			return;
		}
		pickedUp = true;
		Inventory.instance.AddObject (this.gameObject);
	}
}
