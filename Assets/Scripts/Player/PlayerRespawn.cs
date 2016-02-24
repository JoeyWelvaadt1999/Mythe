using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    private Transform lastPosition;
    private Transform checkPointPosition;

    void CheckPointSave()
    {
        lastPosition.transform.position = checkPointPosition.transform.position;
        print("checkpoint touched, position saved");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "CheckPoint")
        {
            CheckPointSave();
        }
    }
}
