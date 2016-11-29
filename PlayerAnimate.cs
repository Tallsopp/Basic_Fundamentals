using UnityEngine;
using System.Collections;

public class PlayerAnimate : MonoBehaviour {

	public Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	void Update () {
		if (Input.GetKeyDown ("1")) {
			anim.Play ("Stand Walk", -1, 0f);
		}

		if (Input.GetKeyDown ("2")) {
			anim.Play ("Stand Run", -1, 0f);
		}

		if (Input.GetKeyDown ("3")) {
			anim.Play ("Crouch Idle", -1, 0f);
		}

		if (Input.GetKeyDown ("4")) {
			anim.Play ("Crouch Walk", -1, 0f);
		}

		if (Input.GetKeyDown ("5")) {
			anim.Play ("Sneak Attack", -1, 0f);
		}
	}
}
