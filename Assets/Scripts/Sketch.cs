using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
  public GameObject myCamera;
  public GameObject capsuleObject;
  public Rigidbody capsule;
  public float speed = 2.0f;

  void Start()
  {
    myCamera = GameObject.Find("Camera");
    capsuleObject = GameObject.Find("Capsule");
    capsule = capsuleObject.GetComponent<Rigidbody>();

    Physics.gravity = new Vector3(0, -100.0f, 0);
  }

  // void FixedUpdate()
  // {
  //   capsule.AddForce(1000.0f, 2000.0f, 3000.0f);

  //   float interpolation = speed * Time.deltaTime;
    
  //   Vector3 position = myCamera.transform.position;
  //   position.x = Mathf.Lerp(myCamera.transform.position.x, capsuleObject.transform.position.x, interpolation);
  //   position.y = Mathf.Lerp(myCamera.transform.position.y, capsuleObject.transform.position.y, interpolation);
  //   position.z = Mathf.Lerp(myCamera.transform.position.z, capsuleObject.transform.position.z, interpolation);

  //   myCamera.transform.position = position;
  // }
}




































