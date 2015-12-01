using UnityEngine;
using System.Collections;

public class FloorCollisions : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D col) {
		if(col.gameObject.tag == Tags.enemyOnParachute){

		}
		if(col.gameObject.tag == Tags.enemyFalling){
			col.gameObject.GetComponent<LifeCounter>().InstantDeath();
		}
	}
}
