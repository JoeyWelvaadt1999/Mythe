using UnityEngine;
using System.Collections;

public class EnemyMeleeAttack : MonoBehaviour
{
    private float _power;
    public bool hasAttacked;
    private Animator _anim;

    void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start ()
    {
	
	}

    void OnEnable()
    {
        EnemyFollow.InitiateAttack += Attack;
    }

    void Attack()
    {
        hasAttacked = true;
        print("I have attacked");
    }

    void OnCollisionEnter2d(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            print("dabdab");
            if (hasAttacked)
            {
                print("power: " + _power);
                hasAttacked = false;
            }

        }
    }
}
