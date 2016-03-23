using UnityEngine;
<<<<<<< HEAD
using System.Collections;
=======
using System.Collections.Generic;
using System.Linq;
>>>>>>> a84a50ee120f0f81d1059133eed40c37d5757ef4

public class PropSpawner : MonoBehaviour
{
    [SerializeField]
    private Vector2 _bounds;
<<<<<<< HEAD
=======
<<<<<<< HEAD
    [SerializeField]
    private GameObject[] _props;

    private float _maxProps = 200;//maximum amount of props that will be instantiated
    private float _maxClusters = 3;
=======
    //[SerializeField]
    //private GameObject[] _props;
>>>>>>> 35e3b104a8541c93baecb2e0da28add2722e69cb

    [SerializeField]
    private List<GameObject> _propList = new List<GameObject>(); 

    private float _maxProps = 200;//maximum amount of props that will be instantiated

    private float _maxClusters = 3;
    private float _currentClusterAmount = 0;
>>>>>>> a84a50ee120f0f81d1059133eed40c37d5757ef4

    private GameObject _treeCluster;
    private Vector2 _clusterBounds;

    private float _minClusterWidth = 5;
    private float _maxClusterWidth = 15;
    private float _minClusterHeight = 5;
    private float _maxClusterHeight = 15;

    //private float _minDis = 1; //minimal distance between props/propclusters
    //private float _maxDis = 10; //maximal distance ^

<<<<<<< HEAD

=======
>>>>>>> a84a50ee120f0f81d1059133eed40c37d5757ef4
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
<<<<<<< HEAD
            GameObject randomProp = _props[Random.Range(0, _props.Length)];
=======
            GameObject randomProp = _propList[Random.Range(0, _propList.Count)];
>>>>>>> a84a50ee120f0f81d1059133eed40c37d5757ef4

            Instantiate(randomProp, new Vector3(randomPosX, randomPosY, 0), Quaternion.identity);
        }
    }
<<<<<<< HEAD


=======
    
>>>>>>> a84a50ee120f0f81d1059133eed40c37d5757ef4
    //work in progress
    void CreateTreeCluster()
    {
        _clusterBounds = new Vector2(
            Random.Range(_minClusterWidth, _maxClusterWidth),
            Random.Range(_minClusterHeight, _maxClusterHeight)
            );

<<<<<<< HEAD
=======
        _treeCluster = new GameObject();

>>>>>>> a84a50ee120f0f81d1059133eed40c37d5757ef4
        for (int x = 0; x < _clusterBounds.x; x++)
        {
            for (int y = 0; y < _clusterBounds.y; y++)
            {
<<<<<<< HEAD
                Instantiate(_props[8], new Vector3(x, y, 0), Quaternion.identity);
            }
        }
=======
                //offset of the tree position so that it won't be squareshaped clusters
                float offsetX = (y % 2 == 0 ? Random.Range(.4f, .8f) : 0f);
                float offsetY = (x % 2 == 0 ? Random.Range(.4f, .8f) : 0f);

                GameObject treeClone = (GameObject)Instantiate(_propList[8], new Vector3(x + offsetX, y + offsetY, 0), Quaternion.identity);
                treeClone.transform.parent = _treeCluster.transform;
            }
        }
        _propList.Add(_treeCluster);
>>>>>>> a84a50ee120f0f81d1059133eed40c37d5757ef4
    }
}
