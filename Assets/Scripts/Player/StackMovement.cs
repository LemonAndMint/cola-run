using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackMovement : MonoBehaviour
{
  public Stack stack;
  private int bottleCount;
  
  void FixedUpdate()
  {
    movement();
  }

  private void movement(){
    bottleCount = stack.bottles.Count;
    for(int i = 1; i < bottleCount && stack.bottles[i] != null ; i++){
      stack.bottles[i].transform.position = Vector3.Lerp(stack.bottles[i - 1].transform.position + Vector3.right,
                                                         stack.bottles[i].transform.position, 0.5f);
    }
  }
}
