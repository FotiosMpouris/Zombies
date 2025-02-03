using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAnimationTrigger : MonoBehaviour
{
    private Animator objectAnimator;

    void Start()
    {
        // Assuming the Animator component is attached to the object GameObject
        objectAnimator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        // Assuming "YourAnimationTrigger" is the name of the trigger parameter in your Animator
        objectAnimator.SetTrigger("YourAnimationTrigger");
    }
}

    void PlayAnimation()
    {
        // Assuming "YourAnimationTrigger" is the name of the trigger parameter in your Animator
        objectAnimator.SetTrigger("YourAnimationTrigger");
    }
}