using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;
using System.ComponentModel;

public class Logic : MonoBehaviour
{

class Gamelogic
{
public int weight; 

public void WriteInfo()
{
 Debug.Log("Вес объекта - " + weight);
}
}

Gamelogic rope = new Gamelogic();

void Start()
{
rope.weight = 15;
rope.WriteInfo();

Debug.Log("объект ");
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
