using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharAnim : MonoBehaviour
{ 
    public Animator myAnim;
    public List<ParticleSystem> effects;
    public List<ParticleSystem> thrusterEffects;
    
    public void ShootAnim()
    {
        myAnim.Play("Shoot");

        foreach (var part in effects)
        {
            part.Play();
        }
    }

    public void ThrusterAnim()
    {
        foreach (var part in thrusterEffects)
        {
            part.Play();
        }
    }
}
