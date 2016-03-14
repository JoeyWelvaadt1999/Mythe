using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
    [SerializeField]
    protected Collider2D _attackTrigger;
    protected bool _attacking ;
    [SerializeField]
    protected float _coolDown;
    private float _timer;

    protected void MeleeAttack()
    {
        StartCoroutine(attackCooldown(0.5f));
    }

    IEnumerator attackCooldown(float time)
    {
        _attacking = true;
        _attackTrigger.enabled = true;
        yield return new WaitForSeconds(time);
        _attacking = false;
        _attackTrigger.enabled = false;
    }
}
