using UnityEngine;
using System.Collections;

public class LifePoints : MonoBehaviour
{
    private float _health = 100;
    public float Health
    {
        get
        {
            return _health;
        }

        set
        {
            _health = value;
        }
    }
}
