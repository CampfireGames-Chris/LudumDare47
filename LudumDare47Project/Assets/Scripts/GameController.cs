using System;
using System.Collections;
using System.Collections.Generic;
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
        Destroy(_thisGame);
        Instantiate(menuScreen);
        _thisMenu = GameObject.FindGameObjectWithTag("menuScreen");
    }
}
