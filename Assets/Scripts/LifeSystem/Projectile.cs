using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public int damage = 1;
	public float velocity = 10f;
	public bool destroyOnHitEnemy = true;
	public bool destroyOnHitParachute = true;

	void Update () {
		transform.Translate(Vector2.up * velocity * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag(Tags.parachute)){
			collider.gameObject.GetComponent<LifeCounter>().TakeDamage(damage);
			if(destroyOnHitParachute){
				Destroy(gameObject);
			}
		}
		if(collider.CompareTag(Tags.enemyOnParachute)){
			collider.gameObject.GetComponent<LifeCounter>().TakeDamage(damage);
			if(destroyOnHitEnemy){
				Destroy(gameObject);
			}
		}
	}
}