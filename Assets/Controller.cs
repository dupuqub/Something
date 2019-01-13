using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
  public string[] joysticks;

  void Start()
  {
    // Get every connected joystick
    joysticks = Input.GetJoystickNames();

    // Show every connected joystick
    foreach (string unit in joysticks) Debug.Log(unit);
  }

  void Update()
  {
    float delta = Time.deltaTime;

    //..........................................................................
    // XBOX360 setup example

    // Colors
    if(Input.GetButton("A")) Debug.Log(delta + ": A");
    if(Input.GetButton("B")) Debug.Log(delta + ": B");
    if(Input.GetButton("X")) Debug.Log(delta + ": X");
    if(Input.GetButton("Y")) Debug.Log(delta + ": Y");

    // Options
    if(Input.GetButton("Back")) Debug.Log(delta + ": Back");
    if(Input.GetButton("Start")) Debug.Log(delta + ": Start");

    // Sticks
    if(Input.GetButton("LSB")) Debug.Log(delta + ": LSB");
    if(Input.GetButton("RSB")) Debug.Log(delta + ": RSB");

    float LSX = Input.GetAxis("LSX");
    float LSY = Input.GetAxis("LSY");
    float RSX = Input.GetAxis("RSX");
    float RSY = Input.GetAxis("RSY");

    if(LSX != 0 || LSY != 0) Debug.Log(delta + ": LSX" + LSX + "; LSY: " + LSY);
    if(RSX != 0 || RSY != 0) Debug.Log(delta + ": RSX" + RSX + "; RSY: " + RSY);

    // Uppers
    if(Input.GetButton("LB")) Debug.Log(delta + ": LB");
    if(Input.GetButton("RB")) Debug.Log(delta + ": RB");

    float LT = Input.GetAxis("LT");
    float RT = Input.GetAxis("RT");

    if(LT != 0) Debug.Log(delta + ": LT: " + LT);
    if(RT != 0) Debug.Log(delta + ": RT: " + RT);

    // Arrows
    if(Input.GetAxis("PadX") < 0) Debug.Log(delta + ": PadLeft");
    else if(Input.GetAxis("PadX") > 0) Debug.Log(delta + ": PadRight");
    if(Input.GetAxis("PadY") < 0) Debug.Log(delta + ": PadBottom");
    else if(Input.GetAxis("PadY") > 0) Debug.Log(delta + ": PadTop");

    //..........................................................................
  }
}
