using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float CrashReloadTime = 2f;
    [SerializeField] ParticleSystem CrashEffect;
    CircleCollider2D playerHead;

    [SerializeField] AudioClip crashSFX;

    bool noCrashYet = true;
    private void Start() 
    {
        playerHead = GetComponent<CircleCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.tag == "Ground" && noCrashYet)
        {
            FindObjectOfType<PlayerController>().CanNotControl();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            CrashEffect.Play();
            Invoke("ReloadScene", CrashReloadTime);
            noCrashYet = false;
            
        }
    }

void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
