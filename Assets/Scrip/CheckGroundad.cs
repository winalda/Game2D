using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGroundad : MonoBehaviour {

	PlayerController playerController;

	// Use this for initialization
	void Start () {
		playerController = GetComponentInParent<PlayerController> ();
	}

	void OnCollisionStay2D(Collision2D coll){
		playerController.groundad = true;
	}

	void OnCollisionExit2D(Collision2D coll){
		playerController.groundad = false;
	}
}
