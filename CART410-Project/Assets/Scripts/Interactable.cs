using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public Interaction startingInteraction;
    public Interaction currentInteraction;
    public string currentText;
    public string interactableName;
    public bool special;
    public Interaction specialInteraction;

    private void Start()
    {
        if (startingInteraction != null)
        {
            currentInteraction = startingInteraction;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (startingInteraction != null)
        {
            currentText = currentInteraction.theText;
        }


    }
}
