using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // UI elements
    public Canvas textBoxCanvas;
    public Text textBoxDialogue;
    public Text textBoxName;
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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
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
