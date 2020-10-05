using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] projectiles;

    public List<GameObject> playerCharacters;

    public int selectedPlayer;

    // Start is called before the first frame update
    void Start()
    {
        DisableAllExcept(selectedPlayer, playerCharacters);
    }
    
    void Update()
    {
        transform.LookAt(transform.parent);
    }

    public void shoot()
    {

    }
    
    private void DisableAllExcept(int choice, List<GameObject> objects)
    {
        foreach (var obj in objects)
        {
            obj.SetActive(obj == objects[choice]);
        }
    }

}
