﻿using UnityEngine;
using System.Collections;

public class ShootAtDirection : MonoBehaviour {

	public GameObject bullet;
	public Transform bulletSpawnPoint;

	void Update () {
#if UNITY_EDITOR
		if(Input.GetMouseButtonDown(0)){
			Debug.Log(ScreenPointToPosition2D.GetZRotation2D(transform.position, transform.position));
			Debug.Log(ScreenPointToPosition2D.GetZRotation2D(transform.position, new Vector3(transform.position.x+1f,transform.position.y,transform.position.z)));
			Debug.Log(ScreenPointToPosition2D.GetZRotation2D(transform.position, new Vector3(transform.position.x-1f,transform.position.y,transform.position.z)));
			ShootToDirection(ScreenPointToPosition2D.GetWorldPosition2D(Input.mousePosition, transform.position.z));
		}
#endif

		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
			ShootToDirection(ScreenPointToPosition2D.GetWorldPosition2D(Input.GetTouch(0).position, transform.position.z));
		}
	}

	void ShootToDirection(Vector3 direction){
		RotateToDirection(direction);
		Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
	}

	void RotateToDirection(Vector3 direction){
		Vector3 newRotation = transform.rotation.eulerAngles;
		newRotation.z = ScreenPointToPosition2D.GetZRotation2D(transform.position, direction);

		transform.rotation = Quaternion.Euler(newRotation);
	}
}
