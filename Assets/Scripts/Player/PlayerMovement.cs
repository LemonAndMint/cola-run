using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public DynamicJoystick joystick;
  public float speed;
  private Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    /*transform.position += (Vector3.right + Vector3.back * joystick.Horizontal) 
                          * Time.deltaTime * speed; */

    rb.MovePosition(rb.position + (Vector3.right + Vector3.back * joystick.Horizontal) 
                                  * Time.deltaTime * speed);
  }
}
