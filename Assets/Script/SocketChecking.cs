using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketChecking : MonoBehaviour
{
    XRSocketInteractor socket;
    Scoring score;
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
        
    }
    public void socketCheck()
    {
    
        IXRSelectInteractable objName = socket.GetOldestInteractableSelected();
    
        score.score+= 10;
    }
}