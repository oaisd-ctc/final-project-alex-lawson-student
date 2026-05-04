using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;

public class Tutorial : MonoBehaviour
{
    public TMP_Text uiText;          // Assign in Inspector
    public string[] messages = new string[] 
    { "Welcome Jesse, to Yappa",
    "I am Mr. White",
    "Right now",
    "We need to Yap",
    "But first, we need to move",
    "Use WASD to move",
    "Now Jesse, listen close",
    "We need to find an NPC",
    "When by NPC",
    "We need to Yap",
    "Press SPACE to Yap",
    "Aim for the green bar",
    "Or else Jesse",
    "You’ll get embarrassed",
    "If embarrassed",
    "You’ll move slower",
    "And the pin moves faster",
    "And remember Jesse",
    "You’re on a timer",
    "Now, go get ‘em Steve"};
    public float interval = 5f;
    private int currentIndex = 0;

    void Start()
    {
        if (uiText == null)
        {
            Debug.LogError("uiText is not assigned!");
            return;
        }

        if (messages.Length > 0)
        {
            uiText.text = messages[currentIndex];
            InvokeRepeating(nameof(ChangeText), interval, interval);
        }
    }

    void ChangeText()
    {
        currentIndex = (currentIndex + 1) % messages.Length;
        uiText.text = messages[currentIndex];
    }
}