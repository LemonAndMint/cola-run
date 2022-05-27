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
    for(int i = 1; i < bottleCount ; i++){
      if(stack.bottles[i] == null){
        stack.bottles.RemoveAt(i);
        continue;
      }
      stack.bottles[i].transform.position = Vector3.Lerp(stack.bottles[i - 1].transform.position + Vector3.right,
                                                         stack.bottles[i].transform.position, 0.5f);
    }
  }
}
