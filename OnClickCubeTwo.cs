using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 


public class OnClickCubeTwo : MonoBehaviour
{

    public GameObject apearingObject;
    public GameObject apearingObject2;
    public GameObject apearingObject3; 
    //public GameObject apearingObject4;

    public GameObject clickObject;
    public GameObject clickObject2;


    void Start ()
    {
         apearingObject.SetActive(false);
         apearingObject2.SetActive(false);
         apearingObject3.SetActive(false);

        // apearingObject4.SetActive(false);

        print("The cube isn't to be seen in the scene");
  
    }
    
    public UnityEvent anEvent;

    private void OnMouseDown()
    {

        Invoke("EventClick", 0.2f);

    }

   /* private void OnMouseDown2()
    {

        Invoke("EventClick2", 0.2f);
        print("EventClick2 started");

    }*/
  

    public void EventClick()
    {
         clickObject.SetActive(false); 
        clickObject2.SetActive(false);

        print("Which also triggered this method as a UnityEvent");

        apearingObject.SetActive(true);
        apearingObject2.SetActive(true);
        apearingObject3.SetActive(true);

    }

  /*  public void EventClick2()
    {
        clickObject.SetActive(false);

        print("Which also triggered this method as a UnityEvent");

        clickObject2.SetActive(true);

    } */
}