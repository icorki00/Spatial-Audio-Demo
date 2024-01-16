using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CustomScript : MonoBehaviour
{

    // Here we have created a number of Events for Wwise integration. 
    // As these are defined as public, we can see the events in the inspector and assign
    // an event too it, such as a play event.
    public AK.Wwise.Event myAudioOne;
    public AK.Wwise.Event myAudioTwo;

    /*
     * A float is a floating point number. It is a numerical parameter which can 
     * make use of decimal points.
     */
    public float fTimer;

    public int iCountdown;

    public Collider[] colliders;

    public GameObject bottomObject;

    private void Start()
    {

        fTimer = 0;

    }

    // Update is called once per frame
    void Update()
    {

        GenerateAudio();

    }


    public void GenerateAudio()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {

            myAudioOne.Post(gameObject);

            Debug.Log("Space was pressed");

        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.CompareTag("FZone"))
        {

            myAudioTwo.Post(bottomObject);

        }

    }

}
