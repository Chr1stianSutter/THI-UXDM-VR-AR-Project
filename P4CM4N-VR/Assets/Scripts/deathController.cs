using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathController : MonoBehaviour
{

  public bool playerIsAlive;

    // Start is called before the first frame update
    void Start()
    {
      playerIsAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
      if (playerIsAlive == false) {
        Debug.Log("YOU DIED");
        UnityEditor.EditorApplication.isPlaying = false;
        //Destroy(this.gameObject);
      }
    }

    void OnTriggerEnter(Collider other)
 {
     if (other.tag == "Enemy")
     {

        Debug.Log("I TOUCHED YOU");
        playerIsAlive = false;
     }
 }
}
