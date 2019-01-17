using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGuideMove : MonoBehaviour
{
  void FixedUpdate()
  {
    GamepadXbox360 gamepad = new GamepadXbox360();
    float LSX = gamepad.LSX;
    float LSY = gamepad.LSY;
    bool LB = gamepad.LB;
    bool RB = gamepad.RB;

    float x = LB && !RB ? -3f : !LB && RB ? 3f : 0f;
    float y = 12f; // Will adapt to acceleration.
    float z = LSY > 0 ? 5f + LSY : LSY < 0 ? 5f * (LSY + 0.5f) : 5f;
    float tilt = LSX * -30f;

    // "0.5f" at "z" is the gamepad's deadzone visual compensation.

    transform.localPosition = new Vector3(x, y, z);
    transform.localRotation = Quaternion.Euler(90, tilt, 0);
  }
}
