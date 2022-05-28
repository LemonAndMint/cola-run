using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleCollision : MonoBehaviour
{
  public BottleManager bm;

  private void OnTriggerEnter(Collider other) {
    GameObject tempObj = other.gameObject; 
    if(tempObj.tag == "obstacle"){
      if(tempObj.GetComponent<Type1Obstacle>() != null){
        tempObj.GetComponent<Type1Obstacle>().DecreaseScore();
      }

      if(tempObj.GetComponent<Type2Obstacle>() != null){
        tempObj.GetComponent<Type2Obstacle>().DecreaseScore();
      }

      if(tempObj.GetComponent<Type3Obstacle>() != null){
        tempObj.GetComponent<Type3Obstacle>().DecreaseScore();
      }

      bm.stack.PopBottles(bm.index);
      bm.bottleDestroy();
    }
  }
}
