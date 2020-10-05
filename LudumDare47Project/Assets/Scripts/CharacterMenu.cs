using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class CharacterMenu : MonoBehaviour
{
    public List<GameObject> characters;
    public GameObject gameController;

    
    public void SelectCharacter(int choice)
    {
        gameController.GetComponent<GameController>().chosenCharacter = choice;
        DisableAllExcept(choice,characters);
    }
    
    private void DisableAllExcept(int choice, List<GameObject> objects)
    {
        foreach (var obj in objects)
        {
            obj.SetActive(obj == objects[choice]);
        }
    }
}
