using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    private PlayerHealth _playerHealth;

    void Awake()
    {
        _playerHealth = GetComponent<PlayerHealth>();
    }

    void TakeDamage(int damageReceived)
    {
        print("damage taken: " + damageReceived);
        _playerHealth.Health = _playerHealth.Health - damageReceived;
        print("health: " + _playerHealth.Health);
    }
}
