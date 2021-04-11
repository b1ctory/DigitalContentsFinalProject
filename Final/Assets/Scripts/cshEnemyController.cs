using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshEnemyController : MonoBehaviour { 
	private int hp = 10;
	public Animation anim;
	public const string DAMAGE	= "Anim_Damage";
	public const string DEATH	= "Anim_Death";
	void Start() {
		anim = GetComponent<Animation>();
	}

	public void Damage() {
		anim.CrossFade (DAMAGE);
		hp--;
		if (hp <= 0) {
			
			anim.CrossFade (DEATH);
			Destroy(gameObject);
		} 
	}
	
	public int GetHP() {
		return hp;
	}
}
