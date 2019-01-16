using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  void FixedUpdate()
  {
    GamepadXbox360 gamepad = new GamepadXbox360();
    float delta = Time.deltaTime;

    string axisX = gamepad.LB && !gamepad.RB ? "Left" : !gamepad.LB && gamepad.RB ? "Right" : "";
    float axisZ = gamepad.LSX != 0 ? gamepad.LSX * 15f : 0;

    GameObject guide = GameObject.Find("CameraGuide" + axisX);
    Vector3 guideVect = guide.transform.position;
    Vector3 guideEuler = guide.transform.rotation.eulerAngles;
    Quaternion guideQuat = Quaternion.Euler(guideEuler.x, guideEuler.y, guideEuler.z + axisZ);

    transform.position = Vector3.Lerp(transform.position, guideVect, delta * 10f);
    transform.rotation = Quaternion.Lerp(transform.rotation, guideQuat, delta * 10f);
  }
}
