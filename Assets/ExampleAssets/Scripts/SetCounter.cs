using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SetCounter : MonoBehaviour
{
    public Text counterText;
    private static int counter = 0;

    // Increment the counter and update the UI Text
    public void IncrementCounter()
    {
        counter++;
        UpdateCounterText();
    }

    // Update the UI Text with the current counter value
    private void UpdateCounterText()
    {
        counterText.text = "Artifacts found: " + counter.ToString() + "/4";
        Debug.Log(counter);
    }
}


   