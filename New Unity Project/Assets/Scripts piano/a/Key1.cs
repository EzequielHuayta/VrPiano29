using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : MonoBehaviour
{
public AudioSource key1;
 void Update() 
{
    if (Input.GetMouseButtonDown(0))
  {
        key1.Play();
    }
else if (Input.GetMouseButtonUp(0))
        key1.Stop();
  
    
}
}
