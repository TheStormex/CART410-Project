using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // UI elements
    public Canvas textBoxCanvas;
    public Text textBoxDialogue;
    public Image textBoxBackground;
    public Text textBoxName;
    public Button textBoxLast;
    public Button textBoxNext;
    public Button textBoxButton1;
    public Button textBoxButton2;

    // music and sounds
     public AudioSource soundWalk;
     public AudioSource soundSong;
     public AudioSource soundIntObject;
     public AudioSource soundIntPerson;
     public AudioSource soundHover;
     public AudioSource soundClick;
     public AudioSource soundEnd;

    // interactables

    // characters
    public Button buttonCandidate;
    public Button buttonCampaign;
    public Button buttonPercy;
    public Button buttonTanner;

    private GameObject currentInteractable;

    // Start is called before the first frame update
    void Start()
    {
        TextboxClose();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // enable / disable the textbox elements
    void TextboxOpen()
    {
        textBoxBackground.gameObject.SetActive(true);
        textBoxDialogue.gameObject.SetActive(true);
        textBoxName.gameObject.SetActive(true);
        textBoxButton1.gameObject.SetActive(true);
        textBoxButton2.gameObject.SetActive(true);
        textBoxLast.gameObject.SetActive(true);
        textBoxNext.gameObject.SetActive(true);
    }

    void TextboxClose()
    {
        textBoxBackground.gameObject.SetActive(false);
        textBoxDialogue.gameObject.SetActive(false);
        textBoxName.gameObject.SetActive(false);
        textBoxButton1.gameObject.SetActive(false);
        textBoxButton2.gameObject.SetActive(false);
        textBoxLast.gameObject.SetActive(false);
        textBoxNext.gameObject.SetActive(false);
    }

    // change the content of the textbox to the beginning of the text
    public void TextboxBegins(GameObject thisInteractable)
    {
        currentInteractable = thisInteractable;
        if (currentInteractable.tag == "character")
        {
            playSoundIntPerson();
        } else
        if (currentInteractable.tag == "object") {
            playSoundIntObject();
        }
        TextboxOpen();
    }

    // end the text box, play the end sound, remove current interactable
    void endInteraction()
    {
        TextboxClose();
        currentInteractable = null;
        playSoundEnd();
    }

    // play the sounds
     public void playSoundWalk()
    {
        soundWalk.Play();
    }
     public void playSoundIntObject()
    {
        soundIntObject.Play();
    }
     public void playSoundIntPerson()
    {
        soundIntPerson.Play();
    }
     public void playSoundHover()
    {
        soundHover.Play();
    }
     public void playsoundClick()
    {
        soundClick.Play();
    }
     public void playSoundEnd()
    {
        soundEnd.Play();
    }
}
