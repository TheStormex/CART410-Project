using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "D_",  menuName = "Interactions/Interaction")]
public class Interaction : ScriptableObject
{
    public string theText;
    public Interaction nextInteraction;
    public Interaction previousInteraction;
    public DialogueOption option1;
    public DialogueOption option2;
    public DialogueOption unlocked;
}
