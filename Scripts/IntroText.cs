using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroText : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    public float displayTime = 3f; // Time in seconds to display the text

    private void Start()
    {
        StartCoroutine(ShowAndHideText());
    }

    IEnumerator ShowAndHideText()
    {
        // Show the text
        displayText.enabled = true;

        // Wait for the specified display time
        yield return new WaitForSeconds(displayTime);

        // Hide the text
        displayText.enabled = false;
    }
}