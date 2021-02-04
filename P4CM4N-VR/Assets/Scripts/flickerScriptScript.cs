using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickerScriptScript : MonoBehaviour
{

  public GameObject scriptToDisable;

  // Start is called before the first frame update
  void Start()
  {
    toggleLight();
  }

  // Update is called once per frame
  void Update()
  {
    //toggleLight();
  }

  IEnumerator waiter(){
    int waitTime = Random.Range(5, 10);
    yield return new WaitForSeconds(waitTime);
    Debug.Log("Waiting for" + waitTime);
    toggleLight();
  }

  void toggleLight(){
    if(scriptToDisable.active == true){

      lightsOff();

    }else if (scriptToDisable.active == false){

      lightsOn();

    }
  }
  void lightsOff(){
    //deactivate
    scriptToDisable.SetActive(false);

    StartCoroutine (waiter());
    Debug.Log("Lights OFF");
  }

  void lightsOn(){
    //activate
    scriptToDisable.SetActive(true);

    StartCoroutine (waiter());
    Debug.Log("Lights ON");
  }
}
