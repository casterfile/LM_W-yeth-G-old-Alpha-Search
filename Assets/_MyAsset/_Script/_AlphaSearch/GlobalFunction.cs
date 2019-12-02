using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFunction : MonoBehaviour {

	private GameObject WallTobeDelete, Balls,CanObject,CanManager;
	public bool isDeleteTopWall = false, isFallNow = false, EndGameNow = false;
	public int countShaking = 0;
	private Animator Anim_CanManager;
	private GameObject[] HideObject;
	// Use this for initialization
	void Start () {
		countShaking = 0;
		isDeleteTopWall = false;

		WallTobeDelete = GameObject.Find("WallTobeDelete");
		Balls = GameObject.Find("Balls");
		CanObject = GameObject.Find("CanObject");
		CanManager = GameObject.Find("CanManager");
		Anim_CanManager = GameObject.Find("PROMILCAN_Anim").GetComponent<Animator>();
		HideObject = GameObject.FindGameObjectsWithTag("hideObject");

		Balls.SetActive(false);
		CanManager.SetActive(false);

		// DeleteTopWall();
	}
	
	// Update is called once per frame
	void Update () {
		if(isFallNow == true){
			CanManager.SetActive(true);
			CanObject.SetActive(false);
			CanObject.GetComponent<Collider>().enabled = false;
			CanObject.transform.localPosition = new Vector3(0f, -1.806f, -2.648594f);
			CanObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
			Anim_CanManager.SetInteger("AnimationNum", 1);

			StartCoroutine(PlayAnimationExpload(4.0f));
		}

		// if(countShaking >= 200){
		// 	DeleteTopWall();
		// }

		if(GameObject.FindGameObjectsWithTag("fry").Length == 0) {
	    	StartCoroutine(PlayAnimationExpload(3.0f));
	 	}
	}


	public void DeleteTopWall(){
		isFallNow = true;
		
		
	}

	IEnumerator PlayAnimationExpload(float Delay)
    {
        
        yield return new WaitForSeconds(Delay);
        // HideObject.SetActive(false);
        for(var i = 0 ; i < HideObject.Length ; i ++)
		 {
		     HideObject[i].SetActive(false);
		 }
        WallTobeDelete.SetActive(false);
        Balls.SetActive(true);
        isDeleteTopWall = true;
    }

    IEnumerator PlayAnimationReverse(float Delay)
    {
        Anim_CanManager.SetInteger("AnimationNum", 2);
        yield return new WaitForSeconds(Delay);
        EndGameNow = true;
    }
}
