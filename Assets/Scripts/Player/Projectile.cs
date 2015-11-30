﻿using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public int damage = 1;
	public float velocity = 10f;
	public bool destroyOnHitDestructibleObject = true;
	public bool destroyOnHitEnemy = true;
	public bool destroyOnHitScenarioObject = true;
	public bool destroyOnHitWall = true;
	//bool startProjectile = false;

	void Update () {
		transform.Translate(Vector2.up * velocity * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider){
		/*
		if(collider.CompareTag(Tags.destructibleObject)){
			collider.gameObject.GetComponent<DestructibleObject>().takeDamage(damage);
			if(destroyOnHitDestructibleObject){
				Destroy(gameObject);
			}
		}
		if(collider.CompareTag(Tags.enemy)){
			collider.gameObject.GetComponent<EnemyLife>().takeDamage(damage);
			if(destroyOnHitEnemy){
				Destroy(gameObject);
			}
		}
		if(collider.CompareTag(Tags.scenarioObject)){
			if(destroyOnHitScenarioObject){
				Destroy(gameObject);
			}
		}
		if(collider.CompareTag(Tags.wall)){
			if(destroyOnHitWall){
				Destroy(gameObject);
			}
		}
		*/

	}

	/*
	public void setStartProjectile(bool startProjectile){
		this.startProjectile = startProjectile;
	}
	*/
}