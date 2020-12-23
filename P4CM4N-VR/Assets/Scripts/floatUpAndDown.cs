using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatUpAndDown : MonoBehaviour
{

  public float amplitude;
  public float frequency;
  public float degreesPerSecond = 15.0f;

  Vector3 posOffset = new Vector3 ();
  Vector3 tempPos = new Vector3 ();

  // Start is called before the first frame update
  void Start()
  {
    posOffset = transform.position;
  }

  // Update is called once per frame
  void Update()
  {
    transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

    tempPos = posOffset;
    tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;

    transform.position = tempPos;
  }
}
