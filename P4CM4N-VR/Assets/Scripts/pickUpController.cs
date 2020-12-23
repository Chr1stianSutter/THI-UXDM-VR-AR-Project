using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpController : MonoBehaviour
{

  public int score=0;
  public AudioClip pickupSound;

    void OnTriggerEnter(Collider other)
 {
     if (other.tag == "Pickup")
     {
         score += 10;
         AudioSource thisAudio = this.gameObject.GetComponent<AudioSource>();
         thisAudio.PlayOneShot (pickupSound);

         other.gameObject.SetActive(false);
     }
 }

 void Update()
 {
   if (score == 960) {
       Debug.Log("YOU WIN !!!");
      UnityEditor.EditorApplication.isPlaying = false;
   }
 }
}
