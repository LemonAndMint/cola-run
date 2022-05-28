using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public Stack stack;
  public GameManager gm;

  private void OnTriggerEnter(Collider other) {
    GameObject tempObj = other.gameObject; 
    if(tempObj.tag == "bottle"){
      stack.AddBottle(tempObj);
    }

    if(tempObj.tag == "obstacle" && stack.bottles.Count <= 1){
      gm.lose();
    }
  }
}
