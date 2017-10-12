using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	public GameObject key;
	public Transform movingPart;
	public Transform pivotPoint;
	public float speed = 20f;

	private bool isOpening;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isOpening && movingPart.eulerAngles.y < 90) {
			movingPart.RotateAround(pivotPoint.transform.position, Vector3.up, speed * Time.deltaTime);
		}
	}

	public void Open() {
		Debug.Log ("open" + Inventory.instance.selectedObj + key);
		if (GameObject.ReferenceEquals(Inventory.instance.selectedObj, key)) {
			Debug.Log("Open");
			isOpening = true;
			Inventory.instance.Use(key);
			return;
		} 
		Feedback.instance.SetText ("Is is locked.");
	}
}
