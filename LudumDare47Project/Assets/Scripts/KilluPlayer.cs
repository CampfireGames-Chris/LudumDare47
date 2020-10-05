using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KilluPlayer : MonoBehaviour
{
    public GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameController.GetComponent<GameController>().EndGame();
        }
    }
}
