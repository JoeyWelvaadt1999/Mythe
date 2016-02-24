using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collide)
    {
        if (collide.gameObject.tag == "Player")
        {
            print("Colliding with player");
            collide.gameObject.SendMessage("TakeDamage", 30);
        }
    }
}
