using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFunction : MonoBehaviour {

	private GameObject WallTobeDelete, Balls,CanObject,CanManager;
	public bool isDeleteTopWall = false;
	public int countShaking = 0;
	// Use this for initialization
	void Start () {
		countShaking = 0;
		isDeleteTopWall = false;

		WallTobeDelete = GameObject.Find("WallTobeDelete");
		Balls = GameObject.Find("Balls");
		CanObject = GameObject.Find("CanObject");
		CanManager = GameObject.Find("CanManager");

		Balls.SetActive(false);
		CanManager.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(isDeleteTopWall == true){
			CanManager.SetActive(true);
			CanObject.SetActive(false);
			CanObject.GetComponent<Collider>().enabled = false;
			CanObject.transform.localPosition = new Vector3(0f, -1.806f, -2.648594f);
			CanObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
		}

		if(countShaking >= 200){
			DeleteTopWall();
		}
	}


	public void DeleteTopWall(){
		WallTobeDelete.SetActive(false);
		Balls.SetActive(true);
		isDeleteTopWall = true;
		
	}
}
