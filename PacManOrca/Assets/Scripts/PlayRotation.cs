using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRotation : MonoBehaviour
{
    public Animator animatorController;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            animatorController.SetTrigger("RotateParam");
            if (audioSource) {
                audioSource.Play();
            }
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            animatorController.SetTrigger("LeftArrow");
            if (audioSource) {
                audioSource.Play();
            }
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            animatorController.SetTrigger("RightArrow");
            if (audioSource) {
                audioSource.Play();
            }
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            animatorController.SetTrigger("UpArrow");
            if (audioSource) {
                audioSource.Play();
            }
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            animatorController.SetTrigger("DownArrow");
            if (audioSource) {
                audioSource.Play();
            }
        }
    }
}
