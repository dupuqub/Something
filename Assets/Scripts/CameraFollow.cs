using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  void FixedUpdate()
  {
    GameObject guide = GameObject.Find("CameraGuide");

    Vector3 oldPosition = transform.position;
    Vector3 newPosition = guide.transform.position;
    Quaternion oldRotation = transform.rotation;
    Quaternion newRotation = guide.transform.rotation;

    float strength = Time.deltaTime * 10f;

    transform.position = Vector3.Lerp(oldPosition, newPosition, strength);
    transform.rotation = Quaternion.Lerp(oldRotation, newRotation, strength);
  }
}
