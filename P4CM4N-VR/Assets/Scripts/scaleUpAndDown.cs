using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleUpAndDown : MonoBehaviour
{

  public float amplitude;
  public Vector3 scale;

  // Update is called once per frame
  void Update()
  {
    for (int i = 0; i < 3; i++){
      scale[i] = amplitude * Mathf.Sin(Time.time) + 1;
      transform.localScale = scale;
    }
  }
}
