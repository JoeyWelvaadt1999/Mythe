using UnityEngine;
using System.Collections;

public class PlayerMeleeAttack : MonoBehaviour
{
    [SerializeField]
    private Collider2D _attackTrigger;
    bool _attacking = false;
    [SerializeField]
    private float _coolDown;
    private float _timer;

	// Use this for initialization
	void Start ()
    {
        _attackTrigger.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space) && !_attacking)
        {
            _attacking = true;
            _attackTrigger.enabled = true;
            _timer = _coolDown;
        }


        if (_attacking)
        {
            if (_timer > 0)
            {
                _timer -= Time.deltaTime;
            }
            else
            {
                _attacking = false;
                _attackTrigger.enabled = false;
            }
        }

	
	}
}
