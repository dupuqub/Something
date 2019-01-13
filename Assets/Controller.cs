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

    // Show every connected joystick (uncomment below)
    // foreach (string unit in joysticks) Debug.Log(unit);

    // Buttons
    if(Input.GetButton("ButtonA")) Debug.Log("ButtonA");
    if(Input.GetButton("ButtonB")) Debug.Log("ButtonB");
    if(Input.GetButton("ButtonX")) Debug.Log("ButtonX");
    if(Input.GetButton("ButtonY")) Debug.Log("ButtonY");

    // Pad
    if(Input.GetAxis("PadHor") < 0) Debug.Log("PadLeft");
    else if(Input.GetAxis("PadHor") > 0) Debug.Log("PadRight");
    if(Input.GetAxis("PadVer") < 0) Debug.Log("PadBottom");
    else if(Input.GetAxis("PadVer") > 0) Debug.Log("PadTop");
  }
}
