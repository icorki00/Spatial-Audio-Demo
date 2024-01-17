using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CustomScript : MonoBehaviour
{

    // Here we have created an event for Wwise integration. 
    // As these are defined as public, we can see the events in the inspector and assign
    // an event too it, such as a play event.
    public AK.Wwise.Event myAudioOne;
            
    // A float is a floating point number. It is a numerical parameter which can 
    // make use of decimal points. It can range from 1.17549e-38 to 3.40282e+38
    public float fTimer;
    public float fCountdown;

    // An int is an Integer number. It is a numerical operator which can is a whole
    // number. It can range from -32767 to 32767
    int iRandom;

    // It is possible to use game objects as a parameter in your code.
    // In the example below, this has actually been set up as an array; a container
    // in which we store a number of different game objects. As this is a public
    // parameter, the objects can be set in the inspector in Unity.
    public GameObject[] headSpace;

    // The start method is called at the beginning.
    // You give parameters a default value in this function.
    private void Start()
    {

        
              
    }

    // Update is called once per frame
    void Update()
    {

        

    }



    public void GenerateAudio()
    {

        

    }

    

}
