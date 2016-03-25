using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PropSpawner : MonoBehaviour
{
    [SerializeField]
    private Vector2 _bounds;
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 0b26ff7302e78b778fc60c6ac590ad41b9b164ed
    [SerializeField]
    private GameObject[] _props;

    private float _maxProps = 200;//maximum amount of props that will be instantiated
    private float _maxClusters = 3;
    //[SerializeField]
    //private GameObject[] _props;
>>>>>>> 35e3b104a8541c93baecb2e0da28add2722e69cb

    [SerializeField]
    private List<GameObject> _propList = new List<GameObject>(); 

    private float _maxProps = 200;//maximum amount of props that will be instantiated

    private float _maxClusters = 3;
    private float _currentClusterAmount = 0;
<<<<<<< HEAD
    [SerializeField]
=======
>>>>>>> a84a50ee120f0f81d1059133eed40c37d5757ef4

>>>>>>> 0b26ff7302e78b778fc60c6ac590ad41b9b164ed
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

            GameObject randomProp = _propList[Random.Range(0, _propList.Count)];

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

        _treeCluster = new GameObject();

        for (int x = 0; x < _clusterBounds.x; x++)
        {
            for (int y = 0; y < _clusterBounds.y; y++)
            {
                Instantiate(_props[8], new Vector3(x, y, 0), Quaternion.identity);
            }
        }
                //offset of the tree position so that it won't be squareshaped clusters
                float offsetX = (y % 2 == 0 ? Random.Range(.4f, .8f) : 0f);
                float offsetY = (x % 2 == 0 ? Random.Range(.4f, .8f) : 0f);

                GameObject treeClone = (GameObject)Instantiate(_propList[8], new Vector3(x + offsetX, y + offsetY, 0), Quaternion.identity);
                treeClone.transform.parent = _treeCluster.transform;
            }
        }
 /*       _propList.Add(_treeCluster);
    }
}*/
