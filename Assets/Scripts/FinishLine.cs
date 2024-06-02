using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    
public class FinishLine : MonoBehaviour
{
    [SerializeField] float FinishDelayTime = 2f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag=="Player")
        {
            finishEffect.Play();
            Invoke("NewScene", FinishDelayTime);
            GetComponent<AudioSource>().Play();
        }
        
    }
    void NewScene()
    {
        SceneManager.LoadScene(0);
    }
}
