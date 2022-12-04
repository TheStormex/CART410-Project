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
        if (currentInteractable != null)
        {
            textBoxName.text = currentInteractable.name;
            textBoxDialogue.text = currentInteractable.gameObject.GetComponent<Interactable>().currentText;
            if (currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.nextInteraction != null)
            {
                textBoxNext.gameObject.GetComponentInChildren<Text>().text = "Next";
            } else
            {
                textBoxNext.gameObject.GetComponentInChildren<Text>().text = "Finish";
            }
            if (currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.previousInteraction != null)
            {
                textBoxLast.gameObject.SetActive(true);
            }
            else
            {
                textBoxLast.gameObject.SetActive(false);
            }
            if (currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.option1 != null && currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.option1.locked == false)
            {
                textBoxButton1.gameObject.SetActive(true);
                textBoxButton1.gameObject.GetComponentInChildren<Text>().text = currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.option1.theOption;

            } else
            {
                textBoxButton1.gameObject.SetActive(false);
            }
            if (currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.option2 != null && currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.option2.locked == false)
            {
                textBoxButton2.gameObject.SetActive(true);
                textBoxButton2.gameObject.GetComponentInChildren<Text>().text = currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.option2.theOption;
            }
            else
            {
                textBoxButton2.gameObject.SetActive(false);
            }
        }
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
        if (currentInteractable == null)
        {
            currentInteractable = thisInteractable;
            if (currentInteractable.tag == "character")
            {
                playSoundIntPerson();
            }
            else
            if (currentInteractable.tag == "object")
            {
                playSoundIntObject();
            }
            TextboxOpen();
        }
    }

    // end the text box, play the end sound, remove current interactable
    public void endInteraction()
    {
        TextboxClose();
        currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction = currentInteractable.gameObject.GetComponent<Interactable>().startingInteraction;
        currentInteractable = null;
        playSoundEnd();
    }

    // when next / finish button is clicked
    public void nextFinishButton()
    {
        if (currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.nextInteraction != null)
        {
            currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction = currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.nextInteraction;
        }
        else
        {
            endInteraction();
        }
    }

    // when previous button is clicked
    public void previousButton()
    {
        if (currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.previousInteraction != null)
        {
            currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction = currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.previousInteraction;
        }
        else
        {
            return;
        }
    }

    // when option 1 button is clicked
    public void option1Clicked()
    {
        currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction = currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.option1.resultingInteraction;
    }

    public void option2Clicked()
    {
        currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction = currentInteractable.gameObject.GetComponent<Interactable>().currentInteraction.option2.resultingInteraction;
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
