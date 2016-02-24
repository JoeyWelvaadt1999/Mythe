using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
