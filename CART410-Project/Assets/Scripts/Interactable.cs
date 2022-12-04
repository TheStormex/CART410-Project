using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public Interaction startingInteraction;
    public Interaction currentInteraction;
    public DialogueOption unlocked;
    public string currentText;
    public string interactableName;

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
        if (unlocked != null)
        {
            unlocked.locked = false;
        }


    }
}
