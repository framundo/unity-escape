using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public static Inventory instance;
	public int rows = 3;
	public int cols = 3;
	public float cellSize = 0.2f;

	public GameObject[,] objects;
	private int count = 0;

	// Use this for initialization
	void Start () {
		instance = this;
		objects = new GameObject[rows, cols];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addObject(GameObject obj) {
		int row = (int) (count / rows);
		int col = (int) (count % cols);
		objects[row, col] = obj;
		float x = col * cellSize;
		float z = row * cellSize;
		obj.transform.position = new Vector3 (x, this.transform.position.y, z);
		count++;
	}
}
