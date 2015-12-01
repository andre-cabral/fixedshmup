using UnityEngine;
using System.Collections;

public class LifeCounter : MonoBehaviour {

	public DamageEffects damageEffects;
	public DeathEffects deathEffects;
	public int maxLife = 5;
	int life = 9999;

	void Awake(){
		life = maxLife;
	}

	public void TakeDamage(int damage){
		life -= damage;
		if(life <= 0){
			if(deathEffects != null){
				deathEffects.DeathEffectsEvents();
			}
		}else{
			if(damageEffects != null){
				damageEffects.DamageEffectsEvents();
			}
		}
	}

	public void InstantDeath(){
		life = 0;
		if(deathEffects != null){
			deathEffects.DeathEffectsEvents();
		}
	}
}
