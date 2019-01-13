using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
  public string[] joysticks;

  void Update()
  {
    // Get every connected joystick
    joysticks = Input.GetJoystickNames();

    // Show every connected joystick
    foreach (string unit in joysticks) Debug.Log(unit);

    //..........................................................................
    // XBOX360 setup

    // Colors
    if(Input.GetButton("A")) Debug.Log("A");
    if(Input.GetButton("B")) Debug.Log("B");
    if(Input.GetButton("X")) Debug.Log("X");
    if(Input.GetButton("Y")) Debug.Log("Y");

    // Uppers
    if(Input.GetButton("LB")) Debug.Log("LB");
    if(Input.GetButton("RB")) Debug.Log("RB");

    // Options
    if(Input.GetButton("Back")) Debug.Log("Back");
    if(Input.GetButton("Start")) Debug.Log("Start");

    // Sticks
    if(Input.GetButton("LS")) Debug.Log("LS");
    if(Input.GetButton("RS")) Debug.Log("RS");

    // Get angle of stick left
    // Get angle of stick right

    // Arrows
    if(Input.GetAxis("PadHor") < 0) Debug.Log("PadLeft");
    else if(Input.GetAxis("PadHor") > 0) Debug.Log("PadRight");
    if(Input.GetAxis("PadVer") < 0) Debug.Log("PadBottom");
    else if(Input.GetAxis("PadVer") > 0) Debug.Log("PadTop");

    // Triggers
    // Get strength of trigger left
    // Get strength of trigger right

    //..........................................................................
  }
}
