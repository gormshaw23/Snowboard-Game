using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayTime = 1f;
    [SerializeField] ParticleSystem finishedEffect; 

    void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Good job! Level reset.");
            finishedEffect.Play(); 
            Invoke("ReloadScene", delayTime);
        }
    }
}
