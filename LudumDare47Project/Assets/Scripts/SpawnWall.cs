using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    public GameObject[] wall;

    public GameObject Cluster;

    // Start is called before the first frame update
    void Start()
    {
        int i = Random.Range(0, wall.Length);

        GameObject wally = Instantiate(wall[i], transform.position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));

        wally.transform.parent = Cluster.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
