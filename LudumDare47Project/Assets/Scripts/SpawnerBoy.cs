using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBoy : MonoBehaviour
{
    public GameObject spawnerBoy;

    public GameObject oldPlanet;

    public GameObject planetToSpawn;

    public float radius = 10;

    private int oldRadius;

    public float space;

    public float actualDist = 0;

    public Rigidbody rb;

    public float rbSpeed = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        space = 20;
    }

    void Update()
    {
        actualDist = Vector3.Distance(spawnerBoy.transform.position, oldPlanet.transform.position);

        if(actualDist>space)
        {
            actualDist = space;

            spawnerBoy.transform.position =new Vector3( oldPlanet.transform.position.x + actualDist,0,0);
        }

        if ( actualDist == space)
        {
            spawnPlanet();
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(rbSpeed, 0, 0);
    }

    public void spawnPlanet()
    {
        GameObject planet = Instantiate(planetToSpawn, spawnerBoy.transform.position, Quaternion.identity);

        planet.GetComponent<SphereCollider>().radius = radius;

        oldRadius = Random.Range(10, 60);

        space = oldRadius + radius;
        actualDist = 0;
    }
}
