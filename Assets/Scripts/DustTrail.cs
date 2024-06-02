using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem dustTrailEffect;
    void OnCollisionEnter2D(Collision2D other) 
    {
        dustTrailEffect.Play();
    }
    
    void OnCollisionExit2D(Collision2D other) 
    {
        dustTrailEffect.Stop();
    }

}
