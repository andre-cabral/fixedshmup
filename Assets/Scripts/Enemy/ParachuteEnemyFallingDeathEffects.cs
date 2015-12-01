using UnityEngine;
using System.Collections;

public class ParachuteEnemyFallingDeathEffects : DeathEffects {
	public GameObject gibs;

	public override void DeathEffectsEvents(){
		gameObject.tag = Tags.enemyDead;
		Instantiate(gibs, transform.position, transform.rotation);

		Destroy(gameObject);
	}
}
