using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad = "PrePlayDropIn"; // Default scene name, you can change it in the Inspector

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
