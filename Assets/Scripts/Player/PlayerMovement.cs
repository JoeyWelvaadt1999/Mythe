using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    Animator _anim;

	CameraZoom _cameraZoom; //Declare variable to camera zoom component
	private float _speed = 3f;

    void Awake() {
        _anim = GetComponent<Animator>();
    }

	void Start() {
		_cameraZoom = Camera.main.GetComponent<CameraZoom> (); //Initialize varible to camerazoom component
	}

    void playerInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _anim.SetBool("isRunningUp", true);
        } else if(Input.GetKeyUp(KeyCode.W))
        {
            _anim.SetBool("isRunningUp", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _anim.SetBool("isRunningUp", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            _anim.SetBool("isRunningUp", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _anim.SetBool("isRunningSideways", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            _anim.SetBool("isRunningSideways", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _anim.SetBool("isRunningSideways", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            _anim.SetBool("isRunningSideways", false);
        }
    }

	void Update () {
        playerInput();
        Move();
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
