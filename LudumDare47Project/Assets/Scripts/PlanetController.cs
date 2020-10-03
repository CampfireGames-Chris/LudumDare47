using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{

    public GameObject player;

    public GameObject spinner;

    public Camera cam;

    public int spinSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotateSpinner();

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

    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player" && Input.GetMouseButtonDown(1))
        {
            player = other.gameObject;

            attachPlayerTospinner();

            cam.transform.position = new Vector3(spinner.transform.position.x, 30, spinner.transform.position.z);
        }
    }
}
