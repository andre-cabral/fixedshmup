using UnityEngine;
using System.Collections;

public class DestroyObjectAfterTime : MonoBehaviour {

	public float timeToDestroy = 5f;

	float timePassed = 0f;


	void Update () {
		timePassed += Time.deltaTime;
		if(timePassed >= timeToDestroy){
			timePassed = 0f;
			Destroy(gameObject);
		}
	}
}
