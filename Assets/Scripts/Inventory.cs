using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public static Inventory instance;
	public int rows = 3;
	public int cols = 3;
	public float cellSize = 0.2f;
	public GameObject selectedObj;
	public GameObject selectSphere;

	public GameObject[] objects;
	private int count = 0;

	// Use this for initialization
	void Start () {
		instance = this;
		objects = new GameObject[rows * cols];
		selectSphere.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddObject(GameObject obj) {
		int row = (int) (count / rows);
		int col = (int) (count % cols);
		objects[count] = obj;
		float x = col * cellSize - cellSize * cols/2;
		float y = row * cellSize - cellSize * rows/2;
		obj.transform.SetParent (this.transform, true);
		obj.transform.localPosition = new Vector3 (x, y, 0);
		count++;
	}

	public void SelectObject(GameObject obj) {
		if(ReferenceEquals(obj, selectedObj)) {
			selectedObj = null;
			selectSphere.SetActive(false);
			return;
		}
		selectedObj = obj;
		selectSphere.SetActive (true);
		selectSphere.transform.position = obj.transform.position;
	}

	public void Use(GameObject obj) {
		int index = ObjectIndex (obj);
		if (index < 0)
			return;
		objects[index] = null;
		selectSphere.SetActive (false);
		Destroy(obj);
	}

	int ObjectIndex(GameObject obj) {
		for (int i = 0; i < objects.Length; i++) {
			if(GameObject.ReferenceEquals(obj, objects[i])) {
				return i;
			}
		}
		return -1;
	}
}
