using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharAnim : MonoBehaviour
{ 
    public Animator myAnim;
    public List<ParticleSystem> effects;
    public List<ParticleSystem> thrusterEffects;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                myAnim.Play("Shoot");

                foreach (var part in effects)
                {
                    part.Play();
                }
                
            }
        }
        if (Input.GetMouseButton(1))
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                foreach (var part in thrusterEffects)
                {
                    part.Play();
                }
                
            }
        }
    }
}
