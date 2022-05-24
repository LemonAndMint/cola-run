using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public DynamicJoystick joystick;
  public float speed;
  // Start is called before the first frame update
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
    transform.position += (Vector3.right + Vector3.back * joystick.Horizontal) 
                          * Time.deltaTime * speed;   
  }
}
