using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject scoreboard;
    
    public GameObject[] projectiles;

    public List<GameObject> playerCharacters;

    public GameObject gameController;

    public GameObject activeCharacter;


    private void Start()
    {
        scoreboard = GameObject.FindGameObjectWithTag("Scoreboard");
    }

    void Update()
    {
        transform.LookAt(transform.parent);

        if (Input.GetMouseButtonDown(0))
        {
            activeCharacter.GetComponent<CharAnim>().ShootAnim();
            Shoot();
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            activeCharacter.GetComponent<CharAnim>().ThrusterAnim();
        }
    }

    private void Shoot()
    {
        if (Physics.Raycast(transform.position, transform.forward, out var hit))
        {
            if (hit.transform.gameObject.CompareTag("Enemy"))
            {
                Destroy(hit.transform.gameObject);
                scoreboard.GetComponent<Scoreboard>().value++;
            }
        }

    }

    public void SetPlayer()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        DisableAllExcept(gameController.GetComponent<GameController>().chosenCharacter, playerCharacters);
    }
    
    private void DisableAllExcept(int choice, List<GameObject> objects)
    {
        activeCharacter = objects[choice];
        foreach (var obj in objects)
        {
            obj.SetActive(obj == objects[choice]);
        }
    }

}
