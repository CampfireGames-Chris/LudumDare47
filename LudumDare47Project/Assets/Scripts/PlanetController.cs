﻿using System.Collections;
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

    public float targetTime = 10.0f;

    private float inTime;

    public bool justLeft=false;

    [Space]

    public bool largePlanet;

    public bool keyPlanet;

    public GameObject[] cluster;

    public GameObject spawnLocation;

    //FUNCTIONS

    void Start()
    {
        cam= GameObject.Find("Main Camera").GetComponent<Camera>();

        inTime = targetTime;
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

        if(justLeft==true)
        {
            timer();
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

            justLeft = true;

            //Destroy(planet);
        }
    }

    public void timer()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            justLeft = false;

            targetTime = inTime;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (justLeft != true)
        {
            if (other.tag == "Player" && Input.GetMouseButton(1))
            {
                player = other.gameObject;

                attachPlayerTospinner();

                if(largePlanet==true)
                {
                    cam.transform.position=new Vector3(cam.transform.position.x,60,cam.transform.position.z);
                }
                else
                {
                    cam.transform.position = new Vector3(cam.transform.position.x, 30, cam.transform.position.z);
                }

                if (keyPlanet == true)
                {
                    player.transform.localPosition = new Vector3(-10, 0, 0);

                    spawnNewCluster();
                }

                // cam.transform.position = new Vector3(spinner.transform.position.x, 50, spinner.transform.position.z);
            }
        }
    }

    public void spawnNewCluster()
    {
        int rand = Random.Range(0, cluster.Length);

        Instantiate(cluster[rand], spawnLocation.transform.position, Quaternion.identity);
    }
}
