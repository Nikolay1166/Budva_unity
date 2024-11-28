using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gljeblogic1 : MonoBehaviour
{
public int [] Sila = new int[1];

private void OnTriggerEnter2D(Collider2D other)
{
if (other.gameObject.tag == "Sila2")
SceneManager.LoadScene (2);

}

}






