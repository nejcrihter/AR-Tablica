using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class VitrBTN : MonoBehaviour
{  
    public GameObject cube;
    public GameObject text;
    public VirtualButtonBehaviour vb;
    
    void Start()
    {
      vb.RegisterOnButtonPressed(OnButtonPressed);
      vb.RegisterOnButtonReleased(OnButtonReleased);
      cube.SetActive(true);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) 
    {
        SceneManager.LoadScene("Audi A6");
        cube.SetActive(false);
        text.SetActive(false);
    }

     public void OnButtonReleased(VirtualButtonBehaviour vb) 
    {
        cube.SetActive(true);
    }

}
