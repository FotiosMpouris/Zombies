using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTrigger : MonoBehaviour
{
    [SerializeField] string nextSceneName = "YourNextSceneName";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Assuming "Player" is the tag of your player GameObject
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        // Load the next scene using SceneManager
        SceneManager.LoadScene(nextSceneName);
    }
}
