using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameScreen;
    public GameObject menuScreen;
    public GameObject playerController;
    public int chosenCharacter;
    
    // Start is called before the first frame update
    void Start()
    {
        gameScreen.SetActive(false);
        menuScreen.SetActive(true);
    }

    // Update is called once per frame
    public void StartGame()
    {
        menuScreen.SetActive(false);
        gameScreen.SetActive(true);
        playerController.GetComponent<PlayerController>().SetPlayer();
    }
}
