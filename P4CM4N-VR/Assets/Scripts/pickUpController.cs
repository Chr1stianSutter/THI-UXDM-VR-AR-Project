using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpController : MonoBehaviour
{

  public int score=0;

    void OnTriggerEnter(Collider other)
 {
     if (other.tag == "Pickup")
     {
         score += 10;
         other.gameObject.SetActive(false);
     }
 }
}
