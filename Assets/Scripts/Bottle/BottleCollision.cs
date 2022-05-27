using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleCollision : MonoBehaviour
{
  public BottleManager bm;

  private void OnTriggerEnter(Collider other) {
    GameObject tempObj = other.gameObject; 
    if(tempObj.tag == "obstacle"){
      bm.stack.PopBottles(bm.index);
      bm.bottleDestroy();
    }
  }
}
