using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MapOnMouseEvents : MonoBehaviour
{
    public SceneAsset scene;
    
    void OnMouseUpAsButton()
    {
        // load a new scene
        SceneManager.LoadScene(scene.name);
    }
}
