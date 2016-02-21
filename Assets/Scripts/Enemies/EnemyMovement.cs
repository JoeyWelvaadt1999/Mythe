using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
    Animator _anim;
	private Vector3 _walkToPos;
	private Vector3 _currentPos;

    void Awake()
    {
        _anim = GetComponent<Animator>();
    }

	void Update() {
		Wander ();
	}

	void Wander() {
		if (_currentPos == Vector3.zero || _currentPos == _walkToPos) {
            _anim.SetBool("isWalking", true);
			_walkToPos = new Vector3 (Random.Range (-36f, 36f), Random.Range (-9f, 9f), 0);
		}

		_currentPos = transform.position;

		transform.position = Vector3.MoveTowards (_currentPos, _walkToPos, 0.05f);
	}
}
