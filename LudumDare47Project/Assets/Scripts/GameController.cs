using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameScreen;
    private GameObject _thisGame;
    
    public GameObject menuScreen;
    private GameObject _thisMenu;
    
    public GameObject playerController;
    public int chosenCharacter;

    public GameObject[] clusters;
    
    // Start is called before the first frame update
    void Start()
    { 
        Instantiate(menuScreen);
        _thisMenu = GameObject.FindGameObjectWithTag("menuScreen");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EndGame();
        }
    }

    // Update is called once per frame
    public void StartGame()
    {
        Destroy(_thisMenu);
        
        Instantiate(gameScreen);
        _thisGame = GameObject.FindGameObjectWithTag("gameScreen");
        
        playerController = GameObject.FindGameObjectWithTag("Player");
        playerController.GetComponent<PlayerController>().SetPlayer();
    }

    public void EndGame()
    {
        clusters = GameObject.FindGameObjectsWithTag("Clusters");
        
        foreach (var obj in clusters)
        {
            Destroy(obj);
        }
        
        Destroy(_thisGame);
        Instantiate(menuScreen);
        _thisMenu = GameObject.FindGameObjectWithTag("menuScreen");
    }
}
