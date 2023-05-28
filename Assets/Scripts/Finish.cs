using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    private float sceneTransitionTime = 2f;
    private bool levelCompleted = false;
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", sceneTransitionTime);
        }
    }

    private void CompleteLevel()
    {
        // using UnityEngine.SceneManagement;
        // Unity> File > Build setting > add open scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
