using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MapOnMouseDown : MonoBehaviour
{
    
    void OnMouseUpAsButton()
    {
        
        Debug.Log("This is a mouse click");
        // load a new scene
        SceneManager.LoadScene("HospitalScene");
    }
}
