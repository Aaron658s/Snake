using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerandJumpUI : MonoBehaviour
{
    private float currentTime;
    public TextMeshProUGUI myTextMeshProUI;

    void Start()
    {
        currentTime = 0f; // Initialize timer to 0
    }
    
    void Update()
    {
        currentTime += Time.deltaTime; // Increment time every frame
        UpdateTimerDisplay(); // Update the UI
    }

    void UpdateTimerDisplay()
    {
        // Convert the current time to seconds (integer)
        int seconds = (int)currentTime;
        // Update the UI Text with the current seconds
        myTextMeshProUI.text = "Timer: " + seconds.ToString();
    }
}
