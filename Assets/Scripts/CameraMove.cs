using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
  void Update()
  {
    GameObject guide = GameObject.Find("CameraGuide");

    transform.position = guide.transform.position;
    transform.rotation = guide.transform.rotation;
  }
}
