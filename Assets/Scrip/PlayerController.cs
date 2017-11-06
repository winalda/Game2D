using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxVelocity = 5f;
	public float speed = 20f;
	private Rigidbody2D rgb2D;
	private Animator animator;
	public bool groundad;

	// Use this for initialization
	void Start () {
		rgb2D = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("speed",Mathf.Abs(rgb2D.velocity.x));
		animator.SetBool ("Grundead", groundad);
	}

	void FixedUpdate(){

		float horizontal = Input.GetAxis ("Horizontal");

		rgb2D.AddForce (Vector2.right * speed * horizontal);

		//El valor clamp regresa los limites superirores e inferiorees que puede alcanazar una variable
		float horizontalVelocity = Mathf.Clamp (rgb2D.velocity.x, -maxVelocity,maxVelocity);
		rgb2D.velocity =  new Vector2(horizontalVelocity,rgb2D.velocity.y);

		if (horizontal > 0.1) {
			transform.localScale = new Vector3 (1f, 1f, 1f);
		} else if (horizontal < -0.1) {
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		}
	}
}
