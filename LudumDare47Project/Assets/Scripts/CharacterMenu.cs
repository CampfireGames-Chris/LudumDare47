using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMenu : MonoBehaviour
{
    public List<GameObject> characters;

    
    public void SelectCharacter(int choice)
    {
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
