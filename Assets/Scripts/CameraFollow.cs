using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  void FixedUpdate()
  {
    GamepadXbox360 gamepad = new GamepadXbox360();
    float delta = Time.deltaTime;
    float diagonal = gamepad.LSX != 0 ? gamepad.LSX * 15f : 0;
    string vertical = gamepad.LSY > 0 ? "Top" : gamepad.LSY < 0 ? "Bottom" : "";
    string horizontal = gamepad.LB && !gamepad.RB ? "Left" : !gamepad.LB && gamepad.RB ? "Right" : "";

    GameObject guide = GameObject.Find("CameraGuide" + horizontal + vertical);
    Vector3 guideVect = guide.transform.position;
    Quaternion guideQuat = guide.transform.rotation;
    Vector3 guideEuler = guideQuat.eulerAngles;
    Quaternion newQuat = Quaternion.Euler(guideEuler.x, guideEuler.y, guideEuler.z + diagonal);

    transform.position = Vector3.Lerp(transform.position, guideVect, delta * 10f);
    transform.rotation = Quaternion.Lerp(transform.rotation, newQuat, delta * 10f);
  }
}
