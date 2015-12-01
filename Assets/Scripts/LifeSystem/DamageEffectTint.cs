using UnityEngine;
using System.Collections;

public class DamageEffectTint : DamageEffects {

	public SpritesTint damageTint;
	public float tintTime = 0.5f;
	float tintTimePassed = 0f;
	bool takingDamage = false;

	public override void DamageEffectsEvents(){
		takingDamage = true;
		tintTimePassed = 0f;
		damageTint.StartTint();
	}

	void Update(){
		if(takingDamage){
			if(tintTimePassed < tintTime){
				tintTimePassed += Time.deltaTime;
			}else{
				tintTimePassed = 0f;
				takingDamage = false;
				damageTint.EndTint();
			}
		}
	}
}
