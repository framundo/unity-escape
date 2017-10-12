using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Feedback : MonoBehaviour {

	public static Feedback instance;
	public Text feedbackText;

	// Use this for initialization
	void Start () {
		instance = this;
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetText(string text) {
		gameObject.SetActive (true);
		this.feedbackText.text = text;
		StartCoroutine (Dissapear());
	}

	IEnumerator Dissapear() {
		yield return new WaitForSeconds(2.0f);
		gameObject.SetActive (false);
	}
}
