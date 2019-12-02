using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	public GameObject UIControl;
	public string SceneName;
	GameObject Canvas;
	GlobalFunction GFunction;
	// Use this for initialization
	void Start () {
		UIControl.SetActive (false);
		Canvas = GameObject.Find("Canvas");
        GFunction = Canvas.GetComponent<GlobalFunction>();
	}
	
	// Update is called once per frame
	void Update () {
		if(GlobalVar.GlobalScore >= 5){
			
		}
		// print("count:"+GameObject.FindGameObjectsWithTag("fry").Length);
		if(GFunction.isDeleteTopWall == true){
			if(GameObject.FindGameObjectsWithTag("fry").Length == 0) {
		    	UIControl.SetActive (true);
		 	}
		}
	}

	public void Restart(){
		Application.LoadLevel(SceneName);
	}
}
