using UnityEngine;
using System.Collections;

public class EnemyFollow : MonoBehaviour
{

    [SerializeField]
    private float _radius;
    private int _layermask;
    [SerializeField]
    private Transform _playerTarget;
    [SerializeField]
    private float followSpeed;
    [SerializeField]
    private float minDistanceFromPlayer;
    [SerializeField]
    private float maxDistanceFromPlayer;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(this.transform.position, _radius);
    }	

    void FollowPlayerTarget()
    {
        Vector3 newEnemyScale = transform.localScale;
        newEnemyScale.x *= -1;
        if (Vector2.Distance(transform.position, _playerTarget.position) >= minDistanceFromPlayer)
        {
            print("im chasing my target");
            if (_playerTarget.transform.localScale.x < 0)
            {
                transform.localScale = newEnemyScale;
                
            }
        }

        if(Vector2.Distance(transform.position, _playerTarget.position) <= maxDistanceFromPlayer)
        {
            print("Initiate attack");
        }
    }

    void Update ()
    {
        Collider2D coll = Physics2D.OverlapCircle(this.transform.position, _radius);
        if (coll != null)
        {
            if (coll.gameObject.tag == "Player")
            {
                print("woop");
                FollowPlayerTarget();
            }
        }

	}
}
