using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    private PlayerHealth _playerHealth;
    private PlayerDeath _playerDeath;
    private PlayerRespawn _playerRespawn;

    void Awake()
    {
        _playerHealth = GetComponent<PlayerHealth>();
        _playerDeath = GetComponent<PlayerDeath>();
        _playerRespawn = FindObjectOfType<PlayerRespawn>();
    }

    void TakeDamage(int damageReceived)
    {
        _playerHealth.Health = _playerHealth.Health - damageReceived;
        print("health: " + _playerHealth.Health);

        if (_playerHealth.Health <= 0)
        {

            StartCoroutine(_playerRespawn.WaitForRespawn(_playerRespawn.RespawnTime));
        }
    }
}
