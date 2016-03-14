using UnityEngine;
using System.Collections;

public class TreeCluster : MonoBehaviour
{
    private Vector2 _clusterBounds;
    private float _maxTrees;

    private float _minClusterWidth = 5;
    private float _maxClusterWidth = 15;
    private float _minClusterHeight = 5;
    private float _maxClusterHeight = 15;
    

    // Use this for initialization
    void Start()
    {
        CreateRandomClusterBounds();
    }

    //creates the size of a cluster, maxTrees is based of the size of a cluster
    void CreateRandomClusterBounds()
    {
        _clusterBounds = new Vector2(
            Random.Range(_minClusterWidth, _maxClusterWidth),
            Random.Range(_minClusterHeight, _maxClusterHeight)
            );

        //_maxTrees = _clusterBounds.x * _clusterBounds.y;
        //Debug.Log(_maxTrees);
    }
}
