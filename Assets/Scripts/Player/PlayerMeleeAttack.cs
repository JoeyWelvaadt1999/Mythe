using UnityEngine;
using System.Collections;

public class PlayerMeleeAttack : Attack
{ 

	// Use this for initialization
	void Start ()
    {
        _attackTrigger.enabled = false;
        _attacking = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            MeleeAttack();
        }


    }
}
