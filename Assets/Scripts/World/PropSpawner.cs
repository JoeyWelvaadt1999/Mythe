using UnityEngine;
using System.Collections;

public class PropSpawner : MonoBehaviour
{
    [SerializeField]
    private Vector2 _bounds; //borders of the game
    [SerializeField]
    private GameObject[] _props;

    private float _maxProps = 200;
    private float _maxClusters = 3;

    [SerializeField]
    private GameObject _treeCluster;
    private Vector2 _clusterbounds;

    private float _minDis = 1; //minimal distance between props/propclusters
    private float _maxDis = 10; //maximal distance ^
    

    void Start()
    {
        //CreateTreeCluster();
        //CreatePropPosition();
        PlaceProps();
    }

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
    /*
    void CreatePropPosition()
    {

    }

    void CreateTreeCluster()
    {
        for (int i = 0; i < _maxClusters; i++)
        {
            
        }
    }
    */
}
