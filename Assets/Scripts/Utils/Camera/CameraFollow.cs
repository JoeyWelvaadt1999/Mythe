using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	[SerializeField]private GameObject _target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Slerp (transform.position, new Vector3(_target.transform.position.x, _target.transform.position.y, transform.position.z), 0.1f);
	}
}
