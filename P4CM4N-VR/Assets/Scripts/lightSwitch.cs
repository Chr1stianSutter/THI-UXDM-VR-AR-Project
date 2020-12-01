using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown("space") && this.gameObject.activeSelf == true)
      {
        Debug.Log("LIGHT OFF");
        this.gameObject.SetActive(false);
      }else{
        Debug.Log("LIGHT ON");
        this.gameObject.SetActive(true);
      }
    }
}
