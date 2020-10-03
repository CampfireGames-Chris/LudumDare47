using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetChooser : MonoBehaviour
{
    public GameObject[] planets;

    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        int i = Random.Range(0, planets.Length);

        GameObject planet = Instantiate(planets[i], transform.position, Quaternion.identity);

        planet.transform.parent = sphere.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
