using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	CameraZoom _cameraZoom; //Declare variable to camera zoom component
	private float _speed = 3f;

	void Start() {
		_cameraZoom = Camera.main.GetComponent<CameraZoom> (); //Initialize varible to camerazoom component
	}

	void Update () {
		Move ();
	}

	void Move() {
		if (Input.GetKey (KeyCode.LeftShift))
			_speed = 3 * 2;
		else if (Input.GetKeyUp (KeyCode.LeftShift))
			_speed = 3;

		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		transform.Translate (x * _speed * Time.deltaTime, y * _speed * Time.deltaTime,0);

		_cameraZoom.SetSize(_speed); //Public function to increase or decrease the camera orthographic size by speed 
	}
}
