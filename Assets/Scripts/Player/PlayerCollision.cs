using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public Stack bottles;

  private void OnTriggerEnter(Collider other) {
    GameObject tempObj = other.gameObject; 
    if(tempObj.tag == "bottle"){
      bottles.AddBottle(tempObj);
      tempObj.tag = "Untagged";
    }
  }
}
