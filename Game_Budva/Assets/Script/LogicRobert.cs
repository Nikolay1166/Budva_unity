using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LogicRobert : MonoBehaviour
{

class Gamelogic
{
public int weight;
public string material;
public string usage;
private string info = "test";
public void WriteInfo() {
    Debug.Log("Вес объекта - " + info + weight + material + usage);
}
}

Gamelogic rope = new Gamelogic();
Gamelogic key = new Gamelogic();
Gamelogic box = new Gamelogic();

void Start()
{
rope.weight = 15;
rope.material = "strings, I guess";
rope.usage = "Grab something far away";
rope.WriteInfo();
Debug.Log("test");
}

public int[] Keys = new int[3];

private void OnTriggerEnter2D(Collider2D other)
{
    if(other.gameObject.tag == "Key0"){
        Keys[0] = 1;
        Destroy(other.gameObject);
    }
}
}
