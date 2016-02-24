using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour
{
    private EnemyHealth _enemyHealth;

    void Awake()
    {
        _enemyHealth = GetComponent<EnemyHealth>();
    }

    void OnCollisionEnter2D(Collision2D collide)
    {
        if (collide.gameObject.tag == "Player")
        {
            print("Colliding with player");
            collide.gameObject.SendMessage("TakeDamage", 30);
        }
    }

    void TakeDamage(int damageReceived)
    {
        print("hit by player weapon");
        _enemyHealth.Health = _enemyHealth.Health - damageReceived;
        if (_enemyHealth.Health <= 0)
        {
            print("I have been slain");
            Destroy(this.gameObject);
        }
    }
}
