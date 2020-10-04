using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnim : MonoBehaviour
{ 
    public Animator _myAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _myAnim.Play("Shoot");
        }
    }
}
