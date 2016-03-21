using UnityEngine;
using System.Collections;

public class PropSpawner : MonoBehaviour
{
    [SerializeField]
    private Vector2 _bounds;
    [SerializeField]
    private GameObject[] _props;

    private float _maxProps = 200;//maximum amount of props that will be instantiated
    private float _maxClusters = 3;

    [SerializeField]
    private GameObject _treeCluster;
    private Vector2 _clusterBounds;

    private float _minClusterWidth = 5;
    private float _maxClusterWidth = 15;
    private float _minClusterHeight = 5;
    private float _maxClusterHeight = 15;

    //private float _minDis = 1; //minimal distance between props/propclusters
    //private float _maxDis = 10; //maximal distance ^


    void Start()
    {
        CreateTreeCluster();
        PlaceProps();
    }

    //work in progress
    void PlaceProps()
    {
        for (int i = 0; i < _maxProps; i++)
        {

            //new position every loop iteration
            float randomPosX = Random.Range(-_bounds.x, _bounds.x);
            float randomPosY = Random.Range(-_bounds.y, _bounds.y);

            //random gameobject every iteration
            GameObject randomProp = _props[Random.Range(0, _props.Length)];

            Instantiate(randomProp, new Vector3(randomPosX, randomPosY, 0), Quaternion.identity);
        }
    }


    //work in progress
    void CreateTreeCluster()
    {
        _clusterBounds = new Vector2(
            Random.Range(_minClusterWidth, _maxClusterWidth),
            Random.Range(_minClusterHeight, _maxClusterHeight)
            );

        for (int x = 0; x < _clusterBounds.x; x++)
        {
            for (int y = 0; y < _clusterBounds.y; y++)
            {
                Instantiate(_props[8], new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }
}
