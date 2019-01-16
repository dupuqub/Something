using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideChangeHeight : MonoBehaviour
{
  void Update()
  {
    float common = 5f;
    float LSY = new GamepadXbox360().LSY;
    float newZ = LSY > 0 ? common + LSY : LSY < 0 ? common * (LSY + 0.5f) : common;
    Vector3 oldLocal = transform.localPosition;
    Vector3 newLocal = new Vector3(oldLocal.x, oldLocal.y, newZ);

    transform.localPosition = newLocal;
  }
}
