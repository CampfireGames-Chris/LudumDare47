using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{

    public GameObject player;

    public GameObject spinner;

    public GameObject planet;

    public Camera cam;

    [Space]

    public int spinSpeed;

    [Space]

    public bool keyPlanet;

    public GameObject[] cluster;

    public GameObject spawnLocation;

    //FUNCTIONS

    void Start()
    {
        cam= GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    void Update()
    {
        if (player != null)
        {
            rotateSpinner();

            playerLeft();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            changeDirection();
        }
    }

    public void attachPlayerTospinner()
    {
        player.transform.parent = spinner.transform;
    }

    public void rotateSpinner()
    {
        spinner.transform.Rotate(0,Time.deltaTime*spinSpeed,0);
    }

    public void changeDirection()
    {
        spinSpeed = spinSpeed * -1;
    }

    public void playerLeft()
    {
        if(spinner.transform.childCount==0)
        {
            player = null;

            //Destroy(planet);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player" && Input.GetMouseButtonDown(1))
        {
            player = other.gameObject;

            attachPlayerTospinner();

            if (keyPlanet == true)
            {
                player.transform.localPosition =new Vector3(-10,0,0);

                spawnNewCluster();
            }

            cam.transform.position = new Vector3(spinner.transform.position.x, 50, spinner.transform.position.z);
        }
    }

    public void spawnNewCluster()
    {
        int rand = Random.Range(0, cluster.Length);

        Instantiate(cluster[rand], spawnLocation.transform.position, Quaternion.identity);
    }
}
