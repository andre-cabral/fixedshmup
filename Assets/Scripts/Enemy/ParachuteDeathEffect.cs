using UnityEngine;
using System.Collections;

public class ParachuteDeathEffect : DeathEffects {

	public GameObject enemyOnParachute;
	public LifeCounter enemyLife;
	public DeathEffects enemyFallingDeathEffects;
	public MoveDown enemyMoveDownScript;
	public float fallingSpeed = 5f;

	public override void DeathEffectsEvents () {
		enemyOnParachute.tag = Tags.enemyFalling;
		gameObject.tag = Tags.parachuteFalling;

		enemyLife.deathEffects = enemyFallingDeathEffects;

		enemyMoveDownScript.speed = fallingSpeed;
	}
}
