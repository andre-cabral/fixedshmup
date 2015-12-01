using UnityEngine;
using System.Collections;

public class ParachuteEnemyDeathEffects : DeathEffects {

	public override void DeathEffectsEvents(){
		gameObject.tag = Tags.enemyDead;

		Destroy(gameObject);
	}
}
