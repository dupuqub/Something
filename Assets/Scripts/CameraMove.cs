using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
  void FixedUpdate()
  {
    GameObject guide = GameObject.Find("CameraGuide");

    transform.position = Vector3.Lerp(transform.position, guide.transform.position, 0.2f);
    transform.rotation = Quaternion.Lerp(transform.rotation, guide.transform.rotation, 0.2f);
  }
}
