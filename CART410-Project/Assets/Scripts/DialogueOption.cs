using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "O_", menuName = "Interactions/DialogueOption")]
public class DialogueOption : ScriptableObject
{
    public string theOption;
    public Interaction resultingInteraction;
}
