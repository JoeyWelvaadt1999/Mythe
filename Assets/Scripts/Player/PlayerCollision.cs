using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    private PlayerHealth _playerHealth;
    private PlayerDeath _playerDeath;

    void Awake()
    {
        _playerHealth = GetComponent<PlayerHealth>();
        _playerDeath = GetComponent<PlayerDeath>();
    }

    void TakeDamage(int damageReceived)
    {
        print("damage taken: " + damageReceived);
        _playerHealth.Health = _playerHealth.Health - damageReceived;
        print("health: " + _playerHealth.Health);
        if (_playerHealth.Health <= 0)
        {
            print("I have died");
            _playerDeath.OnDeath();
        }
    }
}
