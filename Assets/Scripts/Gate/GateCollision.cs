using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateCollision : MonoBehaviour
{
  private void OnTriggerEnter(Collider other) {
    GameObject tempObj = other.gameObject;

    if(tempObj.tag == "glass bottle"){
      tempObj.tag = "plastic bottle";
      tempObj.GetComponent<BottleManager>().changeGFX();
    }

     if(tempObj.tag == "can"){
      tempObj.tag = "glass bottle";
      tempObj.GetComponent<BottleManager>().changeGFX();
    }
  }
}
