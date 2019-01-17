﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGuideMove : MonoBehaviour
{
  void FixedUpdate()
  {
    // Gamepad.
    GamepadXbox360 gamepad = new GamepadXbox360();
    float LSY = gamepad.LSY;
    bool LB = gamepad.LB;
    bool RB = gamepad.RB;

    // Position.
    // (Working perfectly).
    float newX = LB && !RB ? -3f : !LB && RB ? 3f : 0;
    float newZ = LSY > 0 ? 5f + LSY : LSY < 0 ? 5f * (LSY + 0.5f) : 5f;
    Vector3 oldPosition = transform.localPosition;
    Vector3 newPosition = new Vector3(newX, oldPosition.y, newZ);

    transform.localPosition = newPosition;

    // Rotation.
    // (Not working, each step adds "gamepad.LSX * 15f" instead of setting it to "gamepad.LSX * 15f").
    float newTilt = gamepad.LSX * 15f;
    Vector3 euler = transform.localEulerAngles;
    Quaternion newRotation = Quaternion.Euler(euler.x, euler.y, newTilt);

    transform.localRotation = newRotation;
  }
}