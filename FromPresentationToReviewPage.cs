using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class FromPresentationToReviewPage : MonoBehaviour
{

    public GameObject apearingObject;
    public GameObject apearingObject2;
    public GameObject apearingObject3;
    public GameObject apearingObject4;
   public GameObject clickObject;


    void Start()
    {
        //apearingObject4.SetActive(false);
        print("Test1");

    }

    public UnityEvent anEvent;

    private void OnMouseDown()
    {
        
        Invoke("EventClick", 0.2f);
        print("EventClick started");

    }

    public void EventClick()
    {
        apearingObject.SetActive(false);
        apearingObject2.SetActive(false);
        apearingObject3.SetActive(true);
        apearingObject4.SetActive(true);
        clickObject.SetActive(false);

        print("///////////////////////////////Which also triggered this method as a UnityEvent");

       // apearingObject4.SetActive(true);

    }
}