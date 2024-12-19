using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelcharge2 : MonoBehaviour
{
    public void changeScene (int scene)
    {
   SceneManager.LoadScene (1);
    }
       private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene (1);
    }
}

