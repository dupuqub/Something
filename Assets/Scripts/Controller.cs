using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
  public float strength = 2f;

  void FixedUpdate()
  {
    GamepadXbox360 gamepad = new GamepadXbox360();
    float LSX = gamepad.LSX;
    float LSY = gamepad.LSY;
    bool LB = gamepad.LB;
    bool RB = gamepad.RB;

    Rigidbody rigid = gameObject.GetComponent<Rigidbody>();

    if(LSX != 0) rigid.AddTorque(transform.up * strength * LSX);
    if(LSY != 0) rigid.AddTorque(-transform.right * strength * LSY);

    if(!LB && RB) rigid.AddTorque(transform.forward * strength);
    else if(LB && !RB) rigid.AddTorque(-transform.forward * strength);
  }
}
