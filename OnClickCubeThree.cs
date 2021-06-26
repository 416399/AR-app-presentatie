using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class OnClickCubeThree : MonoBehaviour
{
    public UnityEvent anEvent;


    private void OnMouseDown()
    {
        print("You clicked the cube!2");
        anEvent.Invoke(); // Triggers the events you have setup in the inspector
    }

    public void EventClick()
    {
        print("Which also triggered this method as a UnityEvent!");
    }
}