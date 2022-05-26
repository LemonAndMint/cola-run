using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackMovement : MonoBehaviour
{
  public Stack stack;
  private int bottleCount;
  // Start is called before the first frame update
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
    movement();
  }

  private void movement(){
    bottleCount = stack.bottles.Count;
    for(int i = 1; i < bottleCount; i++){
      stack.bottles[i].transform.position = Vector3.Lerp(stack.bottles[i - 1].transform.position + Vector3.right * 1.2f, /*  */ 
                                                         stack.bottles[i].transform.position, 0.9f);
    }
  }
}
