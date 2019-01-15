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
    Vector3 guideEuler = guide.transform.rotation.eulerAngles;
    Quaternion newQuat = Quaternion.Euler(guideEuler.x, guideEuler.y, guideEuler.z + diagonal);

    transform.position = Vector3.Lerp(transform.position, guideVect, delta * 10f);
    transform.rotation = Quaternion.Lerp(transform.rotation, newQuat, delta * 10f);

    // Notes.
    // Ship going down should be on top of the screen (point is too low! Watch for the issue below after fixing).
    // Ship going up should be less inclined (is point too high?).
    // Ship rolling is possibly snapping too hard.
  }
}
