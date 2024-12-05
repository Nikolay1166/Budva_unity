using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public int[] keys = new int[3];
    void Start()
    {
        
    }

public int [] Keys = new int[3];

   




   
    private void OnTriggerEnter2D(Collider2D other)
{
       
    if (other.gameObject.tag == "Key0" ){
        Keys[0] = 1;
        Destroy (other.gameObject);
    }     
        
    if (other.gameObject.tag == "Key1" & Keys[0] == 1 ){
        Keys[1] = 1;
        Destroy (other.gameObject);
    }   
    if (other.gameObject.tag == "Key2" & Keys[1] == 1 ){
       SceneManager.LoadScene (2);
    }      
}
}
