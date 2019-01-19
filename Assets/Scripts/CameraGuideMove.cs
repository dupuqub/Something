using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGuideMove : MonoBehaviour
{
  void FixedUpdate()
  {
    GamepadXbox360 gamepad = new GamepadXbox360();
    float LSX = gamepad.LSX; // From -1 to 1.
    float LSY = gamepad.LSY; // From -1 to 1.
    float LT = gamepad.LT; // From 0 to 1.
    float RT = gamepad.RT; // From 0 to 1.
    bool LB = gamepad.LB;
    bool RB = gamepad.RB;

    float x = LB && !RB ? -3f : !LB && RB ? 3f : 0f;
    float y = 12f + (RT - LT) * 4f;
    float z = LSY > 0 ? 5f + LSY : LSY < 0 ? 5f * (LSY + 0.5f) : 5f;
    float tilt = LSX * -30f;

    // "0.5f" at "z" is the gamepad's deadzone visual compensation.

    Vector3 newPosition = new Vector3(x, y, z);
    Quaternion newRotation = Quaternion.Euler(90, tilt, 0);

    transform.localPosition = Vector3.Lerp(transform.localPosition, newPosition, 0.2f);
    transform.localRotation = Quaternion.Lerp(transform.localRotation, newRotation, 0.2f);
  }
}
