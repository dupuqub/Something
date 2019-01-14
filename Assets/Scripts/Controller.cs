using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
  void FixedUpdate()
  {
    GamepadXbox360 gamepad = new GamepadXbox360();
    float delta = Time.deltaTime;

    if(gamepad.LSX != 0) transform.Rotate(Vector3.up, gamepad.LSX * delta * 100f);
    if(gamepad.LSY != 0) transform.Rotate(Vector3.left, gamepad.LSY * delta * 100f);

    if(!gamepad.LB && gamepad.RB) transform.Rotate(Vector3.forward, delta * 100f);
    else if(gamepad.LB && !gamepad.RB) transform.Rotate(Vector3.back, delta * 100f);
  }
}
