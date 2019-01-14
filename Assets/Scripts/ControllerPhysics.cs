using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPhysics : MonoBehaviour
{
  void FixedUpdate()
  {
    GamepadXbox360 gamepad = new GamepadXbox360();
    float delta = Time.deltaTime;
    Rigidbody rigid = gameObject.GetComponent<Rigidbody>();

    if(gamepad.LSX != 0) rigid.AddTorque(transform.up * gamepad.LSX * delta * 100f);
    if(gamepad.LSY != 0) rigid.AddTorque(-transform.right * gamepad.LSY * delta * 100f);

    if(!gamepad.LB && gamepad.RB) rigid.AddTorque(transform.forward * delta * 100f);
    else if(gamepad.LB && !gamepad.RB) rigid.AddTorque(-transform.forward * delta * 100f);
  }
}
