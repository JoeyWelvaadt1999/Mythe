using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private float _speed = 7f;

	void Update () {
		Move ();
	}

	void Move() {
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		transform.Translate (x * _speed * Time.deltaTime, y * _speed * Time.deltaTime,0);
	}
}
